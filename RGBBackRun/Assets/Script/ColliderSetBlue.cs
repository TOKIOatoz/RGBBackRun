using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSetBlue : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetButtonDown("Blue"))
        {
            this.GetComponent<Collider>().isTrigger = true;
        }
        
        if (Input.GetButtonDown("Green") || Input.GetButtonDown("Red"))
        {
            this.GetComponent<Collider>().isTrigger = false;
        }
    }
}
