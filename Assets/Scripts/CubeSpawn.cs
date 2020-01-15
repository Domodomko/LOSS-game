using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawn : MonoBehaviour
{
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public GameObject enemy;
    public float spawnRate;
    float nextSpawn;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeCatch.number == 1)
        {
            //nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-12.25f, 12.25f);
            randY = Random.Range(-6.86f, 6.86f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            CubeCatch.number = 0;
        }
    }
}
