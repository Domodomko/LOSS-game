using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    int number = 1;
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 1)
        {
            randX = Random.Range(-12.5f, 12.5f);
            randY = Random.Range(-7.5f, 7.5f);
            if ((randX>1f) | (randY>1f))
                    {
              whereToSpawn = new Vector2(randX, randY);
              Instantiate(enemy, whereToSpawn, Quaternion.identity);
              number = 0;
            }
        }
    }
}
