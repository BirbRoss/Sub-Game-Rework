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
    public float rotate;

    private Animator moveAnim;

    public ParticleSystem leftParticle;
    public ParticleSystem rightParticle;

    private void Start()
    {
        moveAnim = GetComponent<Animator>();
    }

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
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            //Decreases speed as long as you above the minimum speed level
            if (speedLevel > -1)
            {
                speedLevel--;
            }
        }
        
        //Manages how fast the player is moving based upon their speed level
        if (speedLevel == -1)
        {
            //Adding force caused the player to accelerate and was really hard to slow down, hense disabled for the time being, but could be readed later with more time to focus on adding realistic acceleration
            //subRB.AddForce(Vector2.down * (speed / 2) * Time.deltaTime, ForceMode2D.Force);

            //sets how fast the player moves (backwards in this case) and updates the speed section of the UI
            subRB.velocity = -transform.up * (speed * 0.5f);
            speedText.text = "Speed: BCK";
        }
        else if (speedLevel == 0)
        {
            //subRB.AddForce(Vector2.zero);

            //Stops player
            subRB.velocity = new Vector2(0, 0);
            speedText.text = "Speed: STP";
        }
        else if (speedLevel == 1)
        {
            //subRB.AddForce(Vector2.up * (speed / 2) * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.up * (speed * 0.5f);
            speedText.text = "Speed: HLF";
        }
        else if (speedLevel == 2)
        {
            //subRB.AddForce(Vector2.up * speed * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.up * speed;
            speedText.text = "Speed: FUL";
        }
        else if (speedLevel == 3)
        {
            //subRB.AddForce(Vector2.up * (speed * 1.5f) * Time.deltaTime, ForceMode2D.Force);
            subRB.velocity = transform.up * (speed * 1.5f);
            speedText.text = "Speed: FLK";
        }

        //Changes to moving animation when the player moves
        if (speedLevel >= 1)
        {
            moveAnim.SetBool("HasSpeed", true);
        }
        else
        {
            moveAnim.SetBool("HasSpeed", false);
        }


        //Uses torque to make a turning circle, but this can be buggy ESPECIALLY when it doesn't register the key press not being lifted, so should be replaced at somepoint, hopefully.
        if (Input.GetKeyDown("a"))
        {
            subRB.AddTorque(rotate * 1.5f);
            leftParticle.Play();
        }
        else if (Input.GetKeyDown("d"))
        {
            subRB.AddTorque(-rotate * 1.5f);
            rightParticle.Play();
        }

        //removes torque once button isn't pressed, stopping the turn by reducing the angular velocity of the player to 0
        if (Input.GetKeyUp("a"))
        {
            slowdown();
            leftParticle.Stop();
        }
        else if (Input.GetKeyUp("d"))
        {
            slowdown();
            rightParticle.Stop();
        }

    }

    void slowdown()
    {
        float vel = subRB.angularVelocity;
        vel = 0;
        subRB.angularVelocity = vel;
    }
}
