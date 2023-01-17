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

    private Animator animator;
    // Update is called once per frame
    void Start()
    {
        animator = GetComponentInChildren<Animator>();    
    }
    void Update()
    {
        //float x = joystick.Horizontal;
        //float z = joystick.Vertical;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (z < 0)
        {
            animator.SetBool("isBackward", true);
            animator.SetBool("isForward", false);
        }
        else if(z > 0)
        {
            animator.SetBool("isBackward", false);
            animator.SetBool("isForward", true);

        }
        else
        {
            animator.SetBool("isBackward", false);
            animator.SetBool("isForward", false);
        }
        Vector3 move = transform.right * x + transform.forward * z;
        float magnitude = Mathf.Clamp01(move.magnitude) * movementSpeed;
        move.Normalize();


        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }


        if(move != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
            Player.Move(movementSpeed * Time.deltaTime * move);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        Player.Move(velocity * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;
    }
        

    public void JumpPlayer()
    {

    }


    public void getSpeed()
    {

    }
}
