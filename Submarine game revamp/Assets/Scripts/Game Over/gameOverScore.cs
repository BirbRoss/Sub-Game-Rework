using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScore : MonoBehaviour
{

    private int score;
    public Text currentText;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("highscore");
        currentText.text = score.ToString();
    }
}
