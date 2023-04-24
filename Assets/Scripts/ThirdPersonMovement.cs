using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// character controller move & jump script based on Unity document
// doesn't use physics, for animation only
// https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller; // bind in inspector
    public Transform cam; // bind the main camera, not cinemachine, in inspector
    public Animator anim; // bind the animator in inspector
    private Rigidbody rb;
    public float jumpForce = 5f;

    public float speed = 6f;
    

    // make jump real world like
    private Vector3 playerVelocity;
    public float jumpHeight = 1f;
    private float gravityValue = -9.81f;
    

    // smooth turning
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

   //  private bool isJumping;
    private bool isGrounded;

    
    
    void Start()
    {
        // lock the cursor 
        // Cursor.lockState = CursorLockMode.Locked;

       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        // don't fall off
        if(isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // for animation movement blend tree
        // should be included in animation script
        // for convenience put it here
        Vector3 velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        anim.SetFloat("speed", velocity.sqrMagnitude);
        

        // for movement
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
   
        
        if(direction.magnitude >= 0.1f) // if is moving
        {
            // calculate the turning angle
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            // smooth the turning angle
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            // rotate the player
            transform.rotation = Quaternion.Euler(0f, angle , 0f);
            
            // move the player
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);

        }

        // jump movement
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            isGrounded = false;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    } 
    
    // if using physics, this would work with colliders added properly
    // void FixedUpdate()
    // {
    //     if(isJumping && isGrounded)
    //     {
    //         rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    //         isJumping = false;
    //         isGrounded = false;
    //     }
    // }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6) // ground
        {
            isGrounded = true;
        }
    }
}
 