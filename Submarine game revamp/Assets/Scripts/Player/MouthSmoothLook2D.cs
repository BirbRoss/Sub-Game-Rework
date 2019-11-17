using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthSmoothLook2D : MonoBehaviour
{
    public Camera theCamera;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = target - transform.position;

        difference.Normalize();

        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion newRotation = Quaternion.Euler(0.0f, 0.0f, rotz + adjustmentAngle);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
    }
}
