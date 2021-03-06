using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowRGB : MonoBehaviour
{
    //Red = 1, Green = 2, Blue = 3
    private int nowRGBFlag = 1;
    public int NowRGBFlag{
        get{return this.nowRGBFlag;}
        set{this.nowRGBFlag = value;}
    }
    void Start()
    {
    }
    void Update()
    {
        if(Input.GetButtonDown("Red"))
        {
            NowRGBFlag = 1;
        }
        else if (Input.GetButtonDown("Green"))
        {
            NowRGBFlag = 2;
        }
        else if (Input.GetButtonDown("Blue"))
        {
            NowRGBFlag = 3;
        }
        Debug.Log(nowRGBFlag);
    }
}