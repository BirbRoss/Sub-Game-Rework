﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subMovement : MonoBehaviour
{
    //Handles speed
    private int speedLevel = 0;
    public Rigidbody2D subRB;
    public Text speedText;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(subRB.velocity.magnitude);

        //Checks if the player hit W or S and adjusts speed acordingly
        if (Input.GetKeyDown("w"))
        {
            //Checks if not already at max speed
            if (speedLevel < 3)
            {
                speedLevel++;
                Debug.Log(speedLevel);
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            //Decreases speed as long as you above the minimum speed level
            if (speedLevel > -1)
            {
                speedLevel--;
                Debug.Log(speedLevel);
            }
        }
        
        //Manages how fast the player is moving based upon their speed level
        if (speedLevel == -1)
        {
            //subRB.AddForce(Vector2.down * (speed / 2) * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = -transform.right * (speed * 0.5f);
            speedText.text = "Speed: BCK";
        }
        else if (speedLevel == 0)
        {
            //subRB.AddForce(Vector2.zero);
            subRB.velocity = new Vector2(0, 0);
            speedText.text = "Speed: STP";
        }
        else if (speedLevel == 1)
        {
            //subRB.AddForce(Vector2.up * (speed / 2) * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.right * (speed * 0.5f);
            speedText.text = "Speed: HLF";
        }
        else if (speedLevel == 2)
        {
            //subRB.AddForce(Vector2.up * speed * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.right * speed;
            speedText.text = "Speed: FUL";
        }
        else if (speedLevel == 3)
        {
            //subRB.AddForce(Vector2.up * (speed * 1.5f) * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.right * (speed * 1.5f);
            speedText.text = "Speed: FLK";
        }

        //Here's where rotation goes when I work that out, probably something to do with doing something like Rotate around(Location + 5x(or -x))
    }
}
