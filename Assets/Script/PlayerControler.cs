using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
	public Animator animator;
	public Rigidbody2D vector;
	public float MaxVelocidade = 10;
	public float moveForce;

	private float walk = 5;
	private float axis;
	private float hForce = 1;
	// Use this for initialization
	void Start()
	{
	}

	void FixedUpdate()
	{

		animator.SetFloat("Speed", vector.velocity.x);
		axis = Input.GetAxis ("Vertical");
        vector.AddForce(Vector2.right * hForce * (vector.velocity.x < walk ? moveForce : moveForce/(vector.velocity.x/2)));
        if (vector.velocity.x > MaxVelocidade)
		{
				
            vector.velocity = new Vector2(Math.Sign(vector.velocity.x) * MaxVelocidade, vector.velocity.y);

        }
		vector.AddForce(axis*Vector2.up/15, ForceMode2D.Impulse);

	}

	// Update is called once per frame
	void Update()
	{
	}

}
