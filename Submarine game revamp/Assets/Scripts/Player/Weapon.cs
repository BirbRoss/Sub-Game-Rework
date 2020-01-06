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

    private void SetFiring()
    {
        isFiring = false;
    }

    private void FireTorp()
    {
        isFiring = true;
        Instantiate(torpPrefab, torpSpawn.position, torpSpawn.rotation);
        Invoke("SetFiring", TorpTime);
    }
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
        if(Input.GetButton("Fire2"))
        {
            if(!isFiring)
            {
                FireTorp();
            }
        }
        if(Input.GetButton("Fire1"))
        {
            if(!isFiring)
            {
                FireLaser();
            }
        }
    }
}
