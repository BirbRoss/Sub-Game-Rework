using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public GameUI scoreKeeper;

    public void Death()
    {
        scoreKeeper.enabled = false;
        SceneManager.LoadScene(0);
    }
}
