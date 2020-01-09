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
        if (collision.gameObject.tag == "Player")
        {
            if(canShoot)
            {
                GetComponent<Collider2D>().enabled = false;
                collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);

                Invoke("ResetTrigger", resetTime);
            }
        }
    }

    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
