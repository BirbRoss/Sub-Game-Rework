using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Main;
    public GameObject Highscore;

    public InputField inName;


    private void Start()
    {
        goBack();
    }

    //Sets the players name, clear the current stored score (just in case), sets has played to true, tells the console the player's name (for debugging purposes) and then loads the game scene 
    public void Play()
    {
        PlayerPrefs.SetString("playerName", inName.text.ToUpper());
        PlayerPrefs.SetInt("highscore", 0);
        Debug.Log(PlayerPrefs.GetString("playerName"));
        SceneManager.LoadScene(1);
    }

    //Closes application, sets the highscore to active to add the current stored highscore to the highscores and sets the currently stored score to 0 so that the highscore doesn't get confused when it starts back up
    public void Quit()
    {
        Highscore.SetActive(true);
        PlayerPrefs.SetInt("highscore", 0);
        Application.Quit();
    }

    //loads the main scene (used in the game over menu)
    public void backToMain()
    {
        SceneManager.LoadScene(0);
    }

    //Sets highscores to visible and main page to invisible
    public void goToScore()
    {
        Highscore.SetActive(true);
        Main.SetActive(false);
    }

    //Sets main page to visible and highscores to invisible
    public void goBack()
    {
        Main.SetActive(true);
        Highscore.SetActive(false);
    }
}
