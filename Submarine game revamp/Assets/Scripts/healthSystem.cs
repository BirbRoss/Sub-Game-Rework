﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class healthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took damage");
        onDamaged.Invoke(health);

        if(health < 1)
        {
            onDie.Invoke();
        }
    }
}
