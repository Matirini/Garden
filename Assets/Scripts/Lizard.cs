using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Attacking))]
public class Lizard : MonoBehaviour
{
    private Animator anim;
    private Attacking attacking;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attacking = GetComponent<Attacking>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;
        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        anim.SetBool("isAttacking", true);
        attacking.Attack(obj);
        
    }
}
