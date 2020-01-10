using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScore : MonoBehaviour
{
 public void reset()
    {
        //reset's the players score when the buttons is pressed
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
