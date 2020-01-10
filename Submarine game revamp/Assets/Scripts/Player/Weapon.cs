using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject torpPrefab;
    public Transform torpSpawn;
    public float TorpTime = 0.5f;

    public GameObject laserPrefab;
    public Transform laserSpawn;
    public float LaserTime = 0.5f;

    private bool isFiring = false;

    public Animator firing;

    //Is the cooldown for weapons, preventing them from firing constantly
    private void SetFiring()
    {
        isFiring = false;
    }

    //Instansiates the torpedo projectile then goes on cooldown
    private void FireTorp()
    {
        isFiring = true;
        Instantiate(torpPrefab, torpSpawn.position, torpSpawn.rotation);
        Invoke("SetFiring", TorpTime);
    }
    //Instansiates the laser projectile then goes on cooldown
    private void FireLaser()
    {
        isFiring = true;
        Quaternion accuracy = Quaternion.Euler(0,0,Random.Range(-7, 7));
        Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation * accuracy);
        Invoke("SetFiring", LaserTime);
    }

    // Update is called once per frame
    void Update()
    {
        //is right click/left alt pressed
        if(Input.GetButton("Fire2"))
        {
            //is not on cooldown
            if(!isFiring)
            {
                FireTorp();

                //prevents from firing rapidly
                firing.SetBool("isFiring", true);
            }
        }

        //is leftclick/left control pressed
        if (Input.GetButton("Fire1"))
        {
            if(!isFiring)
            {
                FireLaser();
                firing.SetBool("isFiring", true);
            }
        }
    }
}
