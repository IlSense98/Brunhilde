using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{


    private Rigidbody2D rb;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

            }

    // Update is called once per frame
    private void Update()
    {

      if(Input.touchCount > 0)
        {

            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }    
    }
}

/*
public class PlayerJump : MonoBehaviour
{


    private Rigidbody2D rb;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.touchCount > 0)
        {

            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}
*/