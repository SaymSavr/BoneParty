using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    enemyDrop ed;

    private void Awake()
    {
        ed = gameObject.GetComponent<enemyDrop>();
    }
    private void Update()
    {
        if (health <= 0)
        {
            ed.enemyDied();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

