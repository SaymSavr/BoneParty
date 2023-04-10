using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayetController : MonoBehaviour
{
    public float playerSpeed;
    private Vector2 direction;
    private Rigidbody2D rb;
    public int bones;
    public TextMeshProUGUI scoreBones;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * playerSpeed * Time.fixedDeltaTime);

        if (direction.x < 0)
            transform.rotation = Quaternion.Euler(0, 180, 0);
        else if (direction.x > 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;
        if(obj.tag == "loot")
        {
            bones++;
            scoreBones.text = ("Bones:" + bones);
            Destroy(obj);
        }
    }
}
