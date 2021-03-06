using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class MoveCube : MonoBehaviour
{
    private Vector3 speed = Vector3.zero;
    private Rigidbody thisRigidbody;
    void Start()
    {
        thisRigidbody = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        speed.x = -5f - (Time.time / 10f);
        thisRigidbody.velocity = speed;
    }
}
