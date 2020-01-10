using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Currently unused but planned feature
public class moveTowardsObject : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;

    public float follow;
    public float retreat;

    // Update is called once per frame
   private void Update()
    {
        //is player not null and further than set follow distance
        if (target != null && (Vector2.Distance(transform.position, target.position) > follow))
        {
            //Move towards target
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
        //is player not null and closer than retreat distance
        else if (target != null && (Vector2.Distance(transform.position, target.position) < retreat))
        {
            //Move away from target
            transform.position = Vector3.MoveTowards(transform.position, target.position, -speed * 0.02f);
        }
        //is player not null, further than retreat but closer than follow
        else if (target != null && (Vector2.Distance(transform.position, target.position) < follow) && (Vector2.Distance(transform.position, target.position) > retreat))
        {
            //Stop moving
            transform.position = transform.position;
        }
    }

    //Usually executed on spawn
    //Set target to target transform (usually player)
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
