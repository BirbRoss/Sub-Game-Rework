using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    //should update health bar and score
    private void OnEnable()
    {
        sendHealth.OnUpdateHealth += UpdateHealthBar;
        addScore.OnSendScore += UpdateScore;
    }

    //updates it one last time befor ebeing destroyed and sends the score to player prefs to be saved
    private void OnDisable()
    {
        sendHealth.OnUpdateHealth += UpdateHealthBar;
        addScore.OnSendScore += UpdateScore;
        PlayerPrefs.SetInt("highscore", playerScore);
    }

    //should update health
    public void UpdateHealthBar(int Health)
    {
        healthBar.value = Health;
    }
    
    //updates score, both UI and value
    private void UpdateScore(int theScore)
    {
        playerScore = playerScore + theScore;
        scoreText.text = "Score: " + playerScore.ToString();
        
    }
}
