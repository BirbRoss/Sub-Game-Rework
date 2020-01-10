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
        //takes the mouse position and the difference between the player and their mouse, rounding this value to a whole number
        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = target - transform.position;
        difference.Normalize();

        //it then finds the current rotation of the object and the target rotation then provides a smoothed curve to it, so it doesn;t just snap to looking at the mouse position
        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion newRotation = Quaternion.Euler(0.0f, 0.0f, rotz + adjustmentAngle);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
    }
}
