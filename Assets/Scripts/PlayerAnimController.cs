using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimController : MonoBehaviour
{
    public Animator anim;
    public NavMeshAgent nav;

    public bool isMoving = false;
    void Start()
    {
  
    }
    void Update()
    {
        if(nav != null && anim != null)
        {
        if (nav.velocity.magnitude==0)
        {
            isMoving = false;
        }
        else if (nav.velocity.magnitude!=0)
        {
            isMoving = true;
        }   
        ToAnimator();
        }
    }

    void ToAnimator()
    {
        
        anim.SetBool("isMoving",isMoving);
    }
}
