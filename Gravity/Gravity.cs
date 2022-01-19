using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private CharacterController cc;
    private bool isGrounded;
    private bool isJumping;

    private float gravity = -9.81f;
    Vector3 velocity = Vector3.zero;
    private float jumpHeight = 3.7f;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isGrounded = cc.isGrounded;
        if (isGrounded)
        {
            velocity.y = 0;
        }
        if(isJumping && isGrounded)
        {
            velocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }

    public void doJump()
    {
        isJumping = true;
        print(isJumping);
    }
}