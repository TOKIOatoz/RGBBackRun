using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndObject : MonoBehaviour
{
    private GameObject cubeBlack;
    private GameObject goTitle;
    private bool endFlag = false;
    public PhaseManager phaseManager;
    void Start()
    {
        cubeBlack = Resources.Load<GameObject>("Prefab/CubeBlack");
        goTitle = Resources.Load<GameObject>("Prefab/GoTitleButton");
    }

    void Update()
    {
        if (phaseManager.PhaseFlag > 0 && !endFlag)
        {
            Instantiate (goTitle);
            endFlag = true;
        }
        if (phaseManager.PhaseFlag > 0)
        {
            Instantiate (cubeBlack, new Vector3(20, 5, 0), Quaternion.identity);
        }
    }
}
