 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothLookAtTarget2D : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;

    // Update is called once per frame
    private void Update()
    {
        //looks towards the target if it exists, using pretty mucht he same code as the smooth mouse look
        if (target != null)
        {
            Vector3 difference = target.position - transform.position;
            float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotz + adjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing);
        }
    }

    //sets the current target (usually upon spawn)
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
