using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public Rigidbody2D objectToAttract;
    public Rigidbody2D attractor;
    public float attractionForce;

    void FixedUpdate()
    {
            objectToAttract = gameObject.GetComponent<Rigidbody2D>();
            attractor = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
            Vector2 direction = attractor.position - objectToAttract.position;
            objectToAttract.AddForce(direction.normalized * attractionForce);
    }
}
