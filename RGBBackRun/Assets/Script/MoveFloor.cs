using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private Vector2 speed2d = Vector2.zero;
    private Renderer rendererFloor;
    private int nameID;
    private float thisScale;
    void Start()
    {
        rendererFloor = GetComponent<Renderer>();
        nameID = Shader.PropertyToID("_MainTex");
        thisScale = this.transform.localScale.x * 10;
    }

    void FixedUpdate()
    {
        speed2d.x = (-5f * Time.time - (Time.time * Time.time / 20f)) / thisScale;
        rendererFloor.sharedMaterial.SetTextureOffset(nameID, speed2d);
    }
}
