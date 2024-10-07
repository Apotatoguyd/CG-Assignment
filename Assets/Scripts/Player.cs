using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float speed;
    public TextMeshProUGUI scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {
        SetScore();

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
    public void SetScore()
    {
        scoreUI.text = "Score: " + score.ToString();

    }
}
