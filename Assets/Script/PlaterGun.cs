using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;
    public float timeBtwShots;
    public float startTimeAtwShots;
    public float offset;
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset); 

        if(timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeAtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
