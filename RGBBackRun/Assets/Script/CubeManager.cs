using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private float pastTime = 0f;
    //0 <= newCubeQuantity <= 3
    private int newCubeQuantity = 1;
    private bool beforeBlackCube = false;
    public int maxPosition = 3;
    public float distance = 4f;
    private int k, l, quantityIndex;
    private GameObject cubeRed;
    private GameObject cubeGreen;
    private GameObject cubeBlue;
    private GameObject cubeBlack;
    public NowRGB nowRGB;
    void Start()
    {
        cubeRed = Resources.Load<GameObject>("Prefab/CubeRed");
        cubeGreen = Resources.Load<GameObject>("Prefab/CubeGreen");
        cubeBlue = Resources.Load<GameObject>("Prefab/CubeBlue");
        cubeBlack = Resources.Load<GameObject>("Prefab/CubeBlack");
        
        AddCube(newCubeQuantity, beforeBlackCube, maxPosition);
    }
    void FixedUpdate()
    {
        if ((Time.time - pastTime) * 5f + ((Time.time * Time.time - pastTime * pastTime) / 10f) > distance)
        {
            DecisionQuantity();
            AddCube(newCubeQuantity, beforeBlackCube, maxPosition);
            pastTime = Time.time;
            Debug.Log(pastTime);
        }
    }

    void DecisionQuantity()
    {
        
        List<int> cubeQuantityList = new List<int>();

        for (k = 0; k < 3; k++)
        {
            for (l = 0; l < 3; l++)
            {
                cubeQuantityList.Add(l);
            }
        }

        cubeQuantityList.Add(3);

        quantityIndex = Random.Range(0, cubeQuantityList.Count);
        newCubeQuantity = cubeQuantityList[quantityIndex];
    }

    void AddCube(int quantity, bool blackCube, int maxPos)
    {
        int listEnd;
        int i, j;
        int colorIndex;
        int positionIndex;
        int[] colorArray = new int[quantity];
        float[] PositionArray = new float[quantity];
        
        List<int> cubePosition = new List<int>();

        for (i = 0; i <= maxPosition; i++)
        {
            cubePosition.Add(i);
        }

        if (blackCube) 
        {
            for (i = 0; i < quantity; i++)
            {
                colorArray[i] = Random.Range(0, 3);
            }
            beforeBlackCube = false;
        }
        else 
        {
            listEnd = quantity * 3 + 1;
        
            List<int> cubeColor = new List<int>();

            for (i = 0; i < quantity; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    cubeColor.Add(j);
                }
            }
            cubeColor.Add(4);

            for (i = 0; i < quantity; i++)
            {
                colorIndex = Random.Range(0, cubeColor.Count);
                colorArray[i] = cubeColor[colorIndex];
                cubeColor.RemoveAt(colorIndex);
                if (colorArray[i] == 4)
                {
                    beforeBlackCube = true;
                }
            }
        }

        for (i = 0; i < quantity; i++)
        {
            positionIndex = Random.Range(0, cubePosition.Count);
            PositionArray[i] = (float)cubePosition[positionIndex] + 0.5f;
            cubePosition.RemoveAt(positionIndex);

            if (colorArray[i] == 1)
            {
                GameObject cloneCube = Instantiate (cubeRed, new Vector3(20f, PositionArray[i], 0), Quaternion.identity);
                cloneCube.GetComponent<InitCubeRed>().getRGBFlag = nowRGB.NowRGBFlag;
            }
            else if (colorArray[i] == 2)
            {
                GameObject cloneCube = Instantiate (cubeGreen, new Vector3(20f, PositionArray[i], 0), Quaternion.identity);
                cloneCube.GetComponent<InitCubeGreen>().getRGBFlag = nowRGB.NowRGBFlag;
            }
            else if (colorArray[i] == 3)
            {
                GameObject cloneCube = Instantiate (cubeBlue, new Vector3(20f, PositionArray[i], 0), Quaternion.identity);
                cloneCube.GetComponent<InitCubeBlue>().getRGBFlag = nowRGB.NowRGBFlag;
            }
            else if (colorArray[i] == 4)
            {
                Instantiate (cubeBlack, new Vector3(20f, PositionArray[i], 0), Quaternion.identity);
            }
        }
    }
}
