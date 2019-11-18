using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public float minTime = 5;
    public float maxTime = 20;

    public bool repeat = false;
    public bool random = false;
    public UnityEvent onTimeerComplete;

    // Start is called before the first frame update
    void Start()
    {
     if (random)
        {
            time = Random.Range(minTime, maxTime);
        }

     if(repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }

    private void OnTimerComplete()
    {
        onTimeerComplete.Invoke();
    }
}
