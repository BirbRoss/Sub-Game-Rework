using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        sendHealth.OnUpdateHealth += UpdateHealthBar;
        addScore.OnSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        sendHealth.OnUpdateHealth -= UpdateHealthBar;
        addScore.OnSendScore -= UpdateScore;
    }

    private void UpdateHealthBar(int Health)
    {
        healthBar.value = Health;
    }
    
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
