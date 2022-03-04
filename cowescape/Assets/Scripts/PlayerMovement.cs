using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private AudioSource footstepsSound;

    [SerializeField] private Joystick joystick;

    public float movementSpeed;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * movementSpeed;

        if (moveInput.x == 0)
        {
            if (!MuteSounds.effectsMuted) {
                footstepsSound.loop = false;
            }
            
            animator.SetBool("isRunning", false);
        }
        else {
            if (!MuteSounds.effectsMuted) {
                footstepsSound.loop = true;
                if (!footstepsSound.isPlaying)
                {
                    footstepsSound.Play();
                }
            }
            animator.SetBool("isRunning", true);
        }

        Vector3 moveVector = (Vector3.up * joystick.Vertical - Vector3.left * joystick.Horizontal);
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
