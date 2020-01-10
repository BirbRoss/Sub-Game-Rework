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
        //deals damage to the object based upon the damage value given
        health = health - damage;

        //invokes die event when the object's health is less than 1
        if (health < 1)
        {
            onDie.Invoke();           
        }

        //This causes the player to recieve 98 damage
        //onDamaged.Invoke(health);

        //sets value of slider (temp fix for above bug)
        healthBar.value = health;
    }


}
