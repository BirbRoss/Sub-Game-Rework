using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PTDamage : MonoBehaviour
{
    public int damage;
    public float resetTime = 0.25f;
    private bool canShoot = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if drone collided with enemy
        if (collision.gameObject.tag == "Player")
        {
            //checks if it's not on cooldown
            if(canShoot)
            {
                //disables it's own collider (so it can't hit multiple times) then tells the player's health system to take damage
                GetComponent<Collider2D>().enabled = false;
                collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);

                //turns on attack cooldown
                Invoke("ResetTrigger", resetTime);
            }
        }
    }

    private void ResetTrigger()
    {
        //re-enables drone's ability to deal damage
        GetComponent<Collider2D>().enabled = true;
    }
}
