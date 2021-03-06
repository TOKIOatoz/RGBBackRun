using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJudgment : MonoBehaviour
{
    public PhaseManager phaseManager;
    void Start()
    {
    }
    void Update()
    {        
    }

    void OnCollisionEnter(Collision collision)
    {
        phaseManager.PhaseFlag++;
    }
}
