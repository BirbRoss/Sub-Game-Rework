using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //if target exists, move towards it
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }

    //typically performed upon spawning
    //Set target, to move to, to target (typically the player)
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
