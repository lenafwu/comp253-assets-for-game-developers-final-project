using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _jumpSpeed = 2.0f;
    [SerializeField] private float _rotationSpeed = 200f;
    // Start is called before the first frame update
    private Rigidbody rb;
    private Animator anim;
    private bool jumpKeyPressed;
    private bool isGrounded;
    private bool isWalking;
    private bool isAttacking;


    private float horizontalInput;
    private float verticalInput;
    private Vector3 movementDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // press F to attack
        if (Input.GetKeyDown(KeyCode.F))
        {
            isAttacking = true;
            anim.SetTrigger("isAttacking");
        }    

        // press space to jump
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpKeyPressed = true;
            anim.SetTrigger("isJumping");
        }

        // press left control to toggle crouch
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetBool("isCrouching", !anim.GetBool("isCrouching"));
        }

        // Get horizontal and vertical input to make the player move
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Rotate player
        transform.Rotate(Vector3.up, horizontalInput * _rotationSpeed * Time.deltaTime);
    }
    private void FixedUpdate() {
        // Put this at the top line so the player can move while doing other actions
        rb.velocity = new Vector3(horizontalInput * _speed, rb.velocity.y, verticalInput * _speed);
        anim.SetFloat("speed", rb.velocity.sqrMagnitude);
        
        // Add a force up when jumping
        if(jumpKeyPressed)
        {
            rb.AddForce(Vector3.up * _jumpSpeed, ForceMode.VelocityChange);
            jumpKeyPressed = false;
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer == 6){
            isGrounded = true;
        }
    }
}
