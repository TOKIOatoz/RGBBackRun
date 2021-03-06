using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCubeBlue : MonoBehaviour
{
    public int getRGBFlag;
    void Start()
    {
    }
    void Update()
    {
        if (getRGBFlag == 3)
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
