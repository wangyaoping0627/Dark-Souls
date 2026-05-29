using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AnimController : MonoBehaviour
{
    public Animator anim;
    public NavMeshAgent nav;
    public bool isMoving = false;
    public bool isStanding = true;
    public bool isAttacking = false;
   
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        nav = GetComponent<NavMeshAgent>(); 
    }
    void Update()
    {
        if(nav == null && anim == null)
        {
            Debug.Log("Nav/Anim is null");
            return;  
        }
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

    void ToAnimator() //传输到动画控制器
    {
        anim.SetBool("isStanding",isStanding);
        anim.SetBool("isMoving",isMoving);
        anim.SetBool("isAttacking",isAttacking);
    }
}
