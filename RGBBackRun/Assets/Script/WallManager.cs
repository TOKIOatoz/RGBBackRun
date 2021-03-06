using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    private Vector3 flontPosition = new Vector3(8f, 5f, 0.6f);
    private Vector3 backPosition = new Vector3(8f, 5f, 1f);
    [SerializeField]
    private GameObject wallRed;
    [SerializeField]
    private GameObject wallGreen;
    [SerializeField]
    private GameObject wallBlue;

    void Start()
    {
        wallRed.transform.position = flontPosition;
        wallGreen.transform.position = backPosition;
        wallBlue.transform.position = backPosition;
    }

    void Update()
    {
        if (Input.GetButtonDown("Red"))
        {
            wallRed.transform.position = flontPosition;
            wallGreen.transform.position = backPosition;
            wallBlue.transform.position = backPosition;
        }
        if (Input.GetButtonDown("Green"))
        {
            wallGreen.transform.position = flontPosition;
            wallRed.transform.position = backPosition;
            wallBlue.transform.position = backPosition;
        }
        if (Input.GetButtonDown("Blue"))
        {
            wallBlue.transform.position = flontPosition;
            wallGreen.transform.position = backPosition;
            wallRed.transform.position = backPosition;
        }
    }
}
