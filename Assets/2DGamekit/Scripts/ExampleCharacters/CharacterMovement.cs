using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float maxSpeed = 10;
    private Rigidbody2D rb;
    private Animator animator;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	private void FixedUpdate () {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, Input.GetAxis("Vertical") * maxSpeed);
        animator.SetBool("moving", (rb.velocity.x != 0 || rb.velocity.y != 0));
	}

    public void OnDeath() {
        Debug.Log("Hi");
    }
}
