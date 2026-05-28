using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;

    private bool isStanding;
    private bool isMoving;
    void Start()
    {
        isStanding = true;
        isMoving = false;
    }
    void Update()
    {
        if (rb.velocity.magnitude != 0)
        {
            isMoving = true;
            isStanding = false;
        }
        else
        {
            isMoving = false;
            isStanding = true; 
        }
        ToAnimator();
    }

    void ToAnimator()
    {
        anim.SetBool("isStanding",isStanding);
        anim.SetBool("isMoving",isMoving);
    }
}
