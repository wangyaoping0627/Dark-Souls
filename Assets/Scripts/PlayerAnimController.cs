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
    public bool isStanding = true;
   
    void Update()
    {
        if(nav != null && anim != null)
        {
        if (nav.velocity.magnitude==0)
        {
            isMoving = false;
            isStanding = true;
            
        }
        else if (nav.velocity.magnitude!=0)
        {
            isMoving = true;
            isStanding = false;
        }   
        ToAnimator();
        }
    }

    void ToAnimator() //传输到动画控制器
    {
        anim.SetBool("isStanding",isStanding);
        anim.SetBool("isMoving",isMoving);
    }
}
