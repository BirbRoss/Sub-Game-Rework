using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PTDamage : MonoBehaviour
{
    public int damage;
    public float resetTime = 0.25f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            GetComponent<Collider2D>().enabled = false;
            Invoke("ResetTrigger", resetTime);
        }
    }

    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
