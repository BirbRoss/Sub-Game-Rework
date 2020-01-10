using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendHealth : MonoBehaviour
{
    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;

    //Should send the health data to the UI but at the moment it applies the player's health value as damage killing them instantly
    public void SendHealthData(int health)
    {
        if(OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }
    }
}
