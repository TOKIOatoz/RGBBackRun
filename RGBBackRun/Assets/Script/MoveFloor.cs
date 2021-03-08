using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private Vector2 speed2d = Vector2.zero;
    private Renderer rendererFloor;
    private int nameID;
    private float thisScale;
    public float nowTime;
    public float startTime;
    void Start()
    {
        rendererFloor = GetComponent<Renderer>();
        nameID = Shader.PropertyToID("_MainTex");
        thisScale = this.transform.localScale.x * 10;
        startTime = Time.time;
        nowTime = 0f;
    }

    void FixedUpdate()
    {
        nowTime = Time.time - startTime;
        speed2d.x = (-5f * nowTime - (nowTime * nowTime / 20f)) / thisScale;
        rendererFloor.sharedMaterial.SetTextureOffset(nameID, speed2d);
    }
}
