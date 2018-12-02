using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text endText;
    public Text scoreText;
    public Text gameOverText;

    public float count;
    public float timer;
    private bool gameOver;
    private int score;

    void Start()
    {
        gameOver = false;
        gameOverText.text = "";
        score = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    /*
        void SetCountText()
    {
        if (count >= 30)
        {
            endText.text = "K.O.!";
            StartCoroutine(ByeAfterDelay(2));
        }
    }

    void FixedUpdate()
    {
        timer = timer + Time.deltaTime;
        if (timer >= 10)
        {
            endText.text = "YOU LOSE :(";
            StartCoroutine(ByeAfterDelay(2));
        }

    }

      IEnumerator ByeAfterDelay(float time)
       {
           yield return new WaitForSeconds(time);

           GameLoader.gameOn = false;
       }
   */
}