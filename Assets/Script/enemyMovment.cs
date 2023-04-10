using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovment : MonoBehaviour
{
    public float enemySpeed;
    Transform target;
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (target.transform.position.x < transform.position.x) // поворот врага
            transform.eulerAngles = new Vector3(0, 180, 0);
        else if (target.transform.position.x > transform.position.x)
            transform.eulerAngles = new Vector3(0, 0, 0);

    }
    void FixedUpdate()
    {    
            transform.position = Vector2.MoveTowards(transform.position, target.position, enemySpeed * Time.deltaTime); // следование за играком
    }
}
