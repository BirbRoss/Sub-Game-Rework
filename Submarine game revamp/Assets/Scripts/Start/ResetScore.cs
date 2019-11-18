using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScore : MonoBehaviour
{
 public void reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
