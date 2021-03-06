using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCubeGreen : MonoBehaviour
{
    public int getRGBFlag;
    void Start()
    {
    }
    void Update()
    {
        if (getRGBFlag == 2)
        {
            this.GetComponent<Collider>().isTrigger = true;
        }
        else
        {
            this.GetComponent<Collider>().isTrigger = false;
        }
        Destroy(this);
    }
}
