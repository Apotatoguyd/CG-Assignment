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
    public WinCondition WC;

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

        if (Input.GetKey(KeyCode.D) && WC.allowMove)
        {
            rb.AddForce(transform.right * speed);
           

        }
        if (Input.GetKey(KeyCode.A) && WC.allowMove)
        {
            rb.AddForce(-transform.right * speed);
            
        }
        if (Input.GetKey(KeyCode.W) && WC.allowMove)
        {
            rb.AddForce(transform.forward * speed);
            
        }
        if (Input.GetKey(KeyCode.S) && WC.allowMove)
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
