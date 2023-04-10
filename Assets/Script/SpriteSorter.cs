using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public bool isStatic = false;
    public float offset = 0;
    private int soringOrderBase = 0;
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(soringOrderBase - transform.position.y + offset);

        if (isStatic)
            Destroy(this);
    }
}
