using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreAmount;
    Text scoreText;
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    int kek;
    int count=1;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + scoreAmount;
        if ((scoreAmount==50) || (scoreAmount == 100) || (scoreAmount == 200))
        {
            kek = count;
        }
        if ((scoreAmount == 51) || (scoreAmount == 101) || (scoreAmount == 201))
        {
            count=1;
        }

        if (kek==1)
        {
            randX = Random.Range(-12.25f, 12.25f);
            randY = Random.Range(-6.86f, 6.86f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            kek = 0;
            count = 0;
        }

        if (scoreAmount == 1000)
        {
            kek = 1;
        }

        if (kek == 1)
        {
            randX = Random.Range(-12.25f, 12.25f);
            randY = Random.Range(-6.86f, 6.86f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            kek = 0;
        }
    }
}
