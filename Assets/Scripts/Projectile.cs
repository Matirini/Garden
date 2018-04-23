using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed, damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        Attacking attacking = collider.gameObject.GetComponent<Attacking>();
        Health health = collider.gameObject.GetComponent<Health>();

        if(attacking && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
