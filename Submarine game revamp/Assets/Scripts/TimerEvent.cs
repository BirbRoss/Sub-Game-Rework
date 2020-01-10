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
    public UnityEvent onTimerComplete;

    private void Start()
    {
        //checks if random is enabled then sets time to a random value
        if (random)
        {
            time = Random.Range(minTime, maxTime);
        }

        //checks if repeat is not checks and if so it will only envoke once or it will envoke repeating every few seconds as set by time
        if (!repeat)
        {
            onTimerComplete.Invoke();
        }
        else
        {
            InvokeRepeating("timerComplete", 0, time);
        }
    }

    //Executes onTimerComplete and randomizes a new time for the invoke to use as a cooldown
    private void timerComplete()
    {
        {
            onTimerComplete.Invoke();

            if (random)
            {
                time = Random.Range(minTime, maxTime);
            }
        }
    }
}