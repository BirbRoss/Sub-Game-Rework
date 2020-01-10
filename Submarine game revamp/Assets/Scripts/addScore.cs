using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;

    public int scoreToAdd = 10;
    private bool scoreSent = false;

    public void OnAddScore()
    {       
        if (!scoreSent)
        {

            Debug.Log("I have been executed");
            scoreSent = true;
            OnSendScore(scoreToAdd);
        }
    }
}
