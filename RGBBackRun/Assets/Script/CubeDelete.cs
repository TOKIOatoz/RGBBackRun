using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDelete : MonoBehaviour
{
    private float posX;
    public float deletePosX = -6.5f;
    void Start()
    {
    }

    void Update()
    {
        posX = this.transform.position.x;
        if (posX < deletePosX)
        {
            Destroy(gameObject);
        }
    }
}
