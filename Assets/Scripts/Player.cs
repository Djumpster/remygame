using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpSpeed = 10f;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private GroundedChecker groundedChecker;

    [SerializeField] private Transform graphic;

    void Update()
    {        
        float velocity_x = GetHorizontalVelocity();
        float velocity_y = GetVerticalVelocity();

        rigidBody.velocity = new Vector2(velocity_x, rigidBody.velocity.y + velocity_y);

        SetForward(velocity_x);
    }

    private float GetVerticalVelocity()
    {
        bool isGrounded = groundedChecker.IsGrounded;
        
        float velocity_y = 0f;

        if (isGrounded)
        {           
            if (Input.GetButtonDown("Jump"))
            {
                velocity_y = jumpSpeed;
            }            
        }

        return velocity_y;
    }

    private float GetHorizontalVelocity()
    {
        return Input.GetAxis("Horizontal") * moveSpeed;
    }


    private void SetForward(float velocity)
    {
        if (velocity > 0f)
        {
            graphic.forward = Vector3.right;
        }
        if (velocity < 0f)
        {
            graphic.forward = Vector3.left;
        }
    }
}
