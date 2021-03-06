using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    private int phaseFlag = 0;
    public int PhaseFlag{
        get{return this.phaseFlag;}
        set{this.phaseFlag = value;}
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
