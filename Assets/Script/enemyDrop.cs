using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyDrop : MonoBehaviour
{
    public int amountOfLoot, maxAmountOfLoot, minAmountOfLoot;
    public GameObject Loot;
    Vector3 randomPosition;


    public void enemyDied()
    {
        amountOfLoot = Random.Range(maxAmountOfLoot, minAmountOfLoot);
        for (int i = 0; i < amountOfLoot; i++)
        {
            randomPosition = transform.position + new Vector3(Random.Range(1, 1.5f), Random.Range(1, 1.5f), 0);
            Instantiate(Loot, randomPosition, Quaternion.EulerAngles(0, 0, Random.Range(0, 180)));
        }
        
    }
}
