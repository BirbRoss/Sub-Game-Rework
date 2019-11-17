using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsObject : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;

    public float follow;
    public float retreat;

    // Update is called once per frame
   private void Update()
    {
        if (target != null && (Vector2.Distance(transform.position, target.position) > follow))
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
        else if (target != null && (Vector2.Distance(transform.position, target.position) < retreat))
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, -speed * 0.02f);
        }
        else if (target != null && (Vector2.Distance(transform.position, target.position) < follow) && (Vector2.Distance(transform.position, target.position) > retreat))
        {
            transform.position = transform.position;
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
