using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public GameUI scoreKeeper;
    private bool isDead = false;

    //executed by an event in the health system, updates bool
    public void Death()
    {
        isDead = true;
    }

    private void Update()
    {
        //disables Player's game object to prevent further collisions and loops then loads the game over screen and scor keeper to prevent the drones that are destroyed when the scene loads to count towards the score.
        if (isDead == true)
        {
            //disable game object
            gameObject.SetActive(false);
            scoreKeeper.enabled = false;
            //Loads main screen
            SceneManager.LoadScene(2);
        }
    }
}
