﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        }
        else if (other.tag == "Enemy")
        {
            other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Die();
        }

    }

    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
