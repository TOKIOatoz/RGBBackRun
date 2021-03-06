using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private GameObject cubeBlack;
    public PhaseManager phaseManager;
    void Start()
    {
        cubeBlack = Resources.Load<GameObject>("Prefab/CubeBlack");
    }

    void Update()
    {
        if (phaseManager.PhaseFlag > 0)
        {
            Instantiate (cubeBlack, new Vector3(20, 5, 0), Quaternion.identity);
        }
    }
}
