using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class LongJump : MonoBehaviour
{
    CharacterController controller;
    public float gravity = 10f;
    public float jumpSpeed = 5f;
    private bool jumpFlag = false;
    private float startThisPositionY;
    private float thisPositionY;
    private Vector3 moveDiraction;
    private float jumpTime;
    private float pastDeltaTime;
    [SerializeField]
    private float jumpTimeLimit = 0.25f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        startThisPositionY = this.transform.position.y + 0.02f;
    }

    void Update()
    {
        thisPositionY = this.transform.position.y;
        if (thisPositionY < startThisPositionY)
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDiraction.y = jumpSpeed;
            }
            jumpFlag = false;
            jumpTime = 0;
        }
        else
        {
            if (Input.GetButton("Jump") && jumpTime < jumpTimeLimit && !jumpFlag)
            {
                    jumpTime += Time.deltaTime;
                    moveDiraction.y = jumpSpeed;
            }

            if (Input.GetButtonUp("Jump") && !jumpFlag)
            {
                jumpFlag = true;
            }
        
        }

        moveDiraction.y -= gravity * Time.deltaTime;
        pastDeltaTime = Time.deltaTime;
        controller.Move(moveDiraction * Time.deltaTime);
    }
}
