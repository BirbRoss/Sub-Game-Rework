using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //allows the object this is place upon to smoothly rotate towards a targets, similar to the smooth mouse script
        Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));
    }
}
