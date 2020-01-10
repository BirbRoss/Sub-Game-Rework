using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Text FName;
    public Text SName;
    public Text TName;

    public Text FText;
    public Text SText;
    public Text TText;

    private int FScore;
    private int SScore;
    private int TScore;

    private void Start()
    {
        if (PlayerPrefs.GetInt("highscore") != 0)
        {
            Test();
        }

        string temp = "AAA";
        string tempScore = "0";

        if (PlayerPrefs.GetString("fName") != "")
        {
            FName.text = PlayerPrefs.GetString("fName");
            FText.text = PlayerPrefs.GetInt("fScore").ToString();
        }
        else
        {
            FName.text = temp;
            FText.text = tempScore;
        }

        if (PlayerPrefs.GetString("sName") != "")
        {
            SName.text = PlayerPrefs.GetString("sName");
            SText.text = PlayerPrefs.GetInt("sScore").ToString();
        }
        else
        {
            SName.text = temp;
            SText.text = tempScore;
        }

        if (PlayerPrefs.GetString("tName") != "")
        {
            TName.text = PlayerPrefs.GetString("tName");
            TText.text = PlayerPrefs.GetInt("tScore").ToString();
        }
        else
        {
            TName.text = temp;
            TText.text = tempScore;
        }


    }

    private void Test()
    {
        int TestScore = PlayerPrefs.GetInt("highscore");
        string Name = PlayerPrefs.GetString("playerName");

        if (PlayerPrefs.GetInt("fScore").ToString() != "")
        {
            FScore = PlayerPrefs.GetInt("fScore");
        }
        else
        {
            FScore = 0;
        }

        if (PlayerPrefs.GetInt("sScore").ToString() != "")
        {
            FScore = PlayerPrefs.GetInt("sScore");
        }
        else
        {
            SScore = 0;
        }

        if (PlayerPrefs.GetInt("tScore").ToString() != "")
        {
            FScore = PlayerPrefs.GetInt("tScore");
        }
        else
        {
            TScore = 0;
        }

        if (TestScore >= TScore)
        {
            if (TestScore >= SScore)
            {
                if (TestScore >= FScore)
                {
                    PlayerPrefs.SetString("tName", PlayerPrefs.GetString("sName"));
                    PlayerPrefs.SetInt("tScore", PlayerPrefs.GetInt("sScore"));
                    PlayerPrefs.SetString("sName", PlayerPrefs.GetString("fName"));
                    PlayerPrefs.SetInt("sScore", PlayerPrefs.GetInt("fScore"));


                    PlayerPrefs.SetString("fName", Name);
                    PlayerPrefs.SetInt("fScore", TestScore);
                }
                else
                {
                    PlayerPrefs.SetString("tName", PlayerPrefs.GetString("sName"));
                    PlayerPrefs.SetInt("tScore", PlayerPrefs.GetInt("sScore"));

                    PlayerPrefs.SetString("sName", Name);
                    PlayerPrefs.SetInt("sScore", TestScore);
                }
            }
            else
            {
                PlayerPrefs.SetString("tName", Name);
                PlayerPrefs.SetInt("tScore", TestScore);
            }
        }

        int temp = 0;
        PlayerPrefs.SetInt("highscore", temp);
    }
}
