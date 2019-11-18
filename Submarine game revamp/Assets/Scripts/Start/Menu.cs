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

    public Image fade;

    private void Start()
    {
        Main.SetActive(true);
        Highscore.SetActive(false);
    }

    public void Play()
    {
        PlayerPrefs.SetString("playerName", inName.text.ToUpper());
        Debug.Log(PlayerPrefs.GetString("playerName"));
        fade.gameObject.SetActive(true);
        Invoke("LoadEvent", 1);
    }

    public void LoadEvent()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
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
