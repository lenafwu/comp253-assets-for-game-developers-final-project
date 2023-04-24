using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim; // bind the animator in inspector
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // press F to attack
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("isAttacking");
        }    

        // press space to jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isJumping");
        }

        // press left control to toggle crouch
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetBool("isCrouching", !anim.GetBool("isCrouching"));
        }
        
        // press I to clap
        if(Input.GetKeyDown(KeyCode.I))
        {
            anim.SetBool("isClapping", !anim.GetBool("isClapping"));
        }
    }
}
