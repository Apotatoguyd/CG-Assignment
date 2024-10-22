using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinCondition : MonoBehaviour
{
    bool winCondition;
    public GameObject winConditionOBJ;
    public TextMeshProUGUI finalTimeToFinish;
    bool loseCondition;
    public GameObject loseConditionOBJ;
    public TextMeshProUGUI timerText;
    private float timer = 15.0f;
    private float finalTime;
    public bool allowMove = true;
    public Player p;

    void Start()
    {
        winConditionOBJ.SetActive(false);
        loseConditionOBJ.SetActive(false);
    }

    void Update()
    {
        if (p.score >= 3)
        {
            winCondition = true;
        }

        if (winCondition)
        {
            winConditionOBJ.SetActive(true);
            allowMove = false;
        }
        
    }

    void FixedUpdate()
    {
        finalTime = timer;
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            CountdownTimer();
        }
        if (timer == 0 )
        {
            loseConditionOBJ.SetActive(true);
            allowMove = false;
        }
        if (timer > 0 && p.score >= 3)
        {
            timer = finalTime;
            finalTimeToFinish.text = "Final Time: " + finalTime.ToString(format:"F1"); 
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void CountdownTimer()
    {
        timerText.text = "Timer: " + timer.ToString("F1");
    }

}
