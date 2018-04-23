using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Attacking attacking = collider.gameObject.GetComponent<Attacking>();

        if (attacking)
        {
            animator.SetTrigger("underAttackTrigger");
        }
    }
}   
