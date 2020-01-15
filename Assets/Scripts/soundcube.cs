using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcube : MonoBehaviour
{
    public AudioSource someSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeCatch.soundeff == 1)
        {
            someSound.Play();
            CubeCatch.soundeff = 0;
        }
    }
}
