using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCatch : MonoBehaviour
{
    public static int number=1;
    public static int soundeff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "KEK")
        {
            score.scoreAmount = score.scoreAmount + 1;
            soundeff = 1;
            Destroy(gameObject);
            number = 1;
        }
    }
}
