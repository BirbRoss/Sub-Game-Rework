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
        Main.SetActive(true);
        Highscore.SetActive(false);
    }

    public void Play()
    {
        PlayerPrefs.SetString("playerName", inName.text.ToUpper());
        PlayerPrefs.SetInt("highscore", 0);
        Debug.Log(PlayerPrefs.GetString("playerName"));
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void backToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void goToScore()
    {
        Highscore.SetActive(true);
        Main.SetActive(false);
    }

    public void goBack()
    {
        Main.SetActive(true);
        Highscore.SetActive(false);
    }
}
