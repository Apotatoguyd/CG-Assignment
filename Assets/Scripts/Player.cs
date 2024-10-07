using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
           

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
      
        }
    }

    public void Score()
    {
        score += 1;
    }
}
