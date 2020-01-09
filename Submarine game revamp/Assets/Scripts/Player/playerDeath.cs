using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public GameUI scoreKeeper;
    private bool isDead = false;

    public void Death()
    {
        isDead = true;
    }

    private void Update()
    {
        if (isDead == true)
        {
            //disable game object
            gameObject.SetActive(false);
            scoreKeeper.enabled = false;
            //Loads main screen
            SceneManager.LoadScene(0);
        }
    }
}
