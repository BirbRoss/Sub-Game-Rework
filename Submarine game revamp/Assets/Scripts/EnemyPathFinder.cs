using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyPathFinder : MonoBehaviour
{
    public Transform target;
    private IAstarAI ai;

    // Start is called before the first frame update
    private void Start()
    {
        ai = GetComponent<IAstarAI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(target != null && ai != null)
        {
            ai.destination = target.position;
            ai.SearchPath();
        }
        Debug.DrawLine(transform.position, target.position, Color.green);
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
