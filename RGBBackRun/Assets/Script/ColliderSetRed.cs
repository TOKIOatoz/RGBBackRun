using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSetRed : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetButtonDown("Red"))
        {
            this.GetComponent<Collider>().isTrigger = true;
        }
        
        if (Input.GetButtonDown("Blue") || Input.GetButtonDown("Green"))
        {
            this.GetComponent<Collider>().isTrigger = false;
        }
    }
}
