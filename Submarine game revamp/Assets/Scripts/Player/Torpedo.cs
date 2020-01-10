using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Also placed on laser, but renaming the script would break it
public class Torpedo : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;

    // Start is called before the first frame update
    private void Start()
    {
        //Adds a force to the projectile it's placed on
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //does collision have enemy tag?
        if (other.tag == "Enemy")
        {
            //Tells collision to kill itself then projectile destroys itself
            other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Die();
        }
        //is not player (e.g. asteroid tile) then destroy itself
        else if (other.tag != "Player")
        {
            Die();
        }

    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
