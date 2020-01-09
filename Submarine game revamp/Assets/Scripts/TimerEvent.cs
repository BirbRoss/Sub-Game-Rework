using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    public float time;
    public float minTime = 5;
    public float maxTime = 20;

    public bool repeat = false;
    public bool random = false;
    public UnityEvent onTimeerComplete;

    private void Start()
    {
        if (random)
        {
            time = Random.Range(minTime, maxTime);
        }

        if (!repeat)
        {
            onTimeerComplete.Invoke();
        }
        else
        {
            InvokeRepeating("timerComplete", 0, time);
        }
    }

    private void timerComplete()
    {
        {
            onTimeerComplete.Invoke();

            if (random)
            {
                time = Random.Range(minTime, maxTime);
            }
        }
    }
}