using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class healthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public Slider healthBar;

    public void TakeDamage(int damage)
    {
        health = health - damage;

        if (health < 1)
        {
            onDie.Invoke();           
        }

        //This causes the player to recieve 98 damage
        //onDamaged.Invoke(health);

        healthBar.value = health;
        Debug.Log(health);
    }


}
