using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CnControls;

public class controll : MonoBehaviour
{

    public float speed = 20f;
    public float padding = 0.1f;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    int kek;
    int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((score.scoreAmount == 50) || (score.scoreAmount == 100) || (score.scoreAmount == 200))
        {
            kek = count;
        }
        if ((score.scoreAmount == 51) || (score.scoreAmount == 101) || (score.scoreAmount == 201))
        {
            count = 1;
        }

        if (kek == 1)
        {
            speed = speed + 0.3f;
            kek = 0;
            count = 0;
        }

        Vector2 moveInput = new Vector2(CnInputManager.GetAxisRaw("Horizontal"), CnInputManager.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity * speed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Respawn")
        {
            SceneManager.LoadScene(2);
        }
    }
}