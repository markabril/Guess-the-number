using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Player;
    public float movementSpeed = 12f;
    public float gravity = 1f;
    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;
    public float jumpHeight = 10f;
    public float airResistance = 10f;


    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //float x = joystick.Horizontal;
        //float z = joystick.Vertical;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;


        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }
        Player.Move(velocity * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;
        Player.Move(movementSpeed * Time.deltaTime * move);
    }
        

    public void JumpPlayer()
    {

    }
}
