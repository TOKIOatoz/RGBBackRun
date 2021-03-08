using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float nowTime;
    public float startTime;
    void Start()
    {
        startTime = Time.time;
        nowTime = Time.time;
    }

    void Update()
    {
        nowTime = Time.time - startTime;
        Debug.Log(startTime);
    }
}
