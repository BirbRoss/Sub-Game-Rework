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
            PlayerPrefs.SetInt("highscore", playerScore);
            Debug.Log(PlayerPrefs.GetInt("highscore"));
            scoreText.text = "Score: " + playerScore.ToString();
    }
}
