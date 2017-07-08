using UnityEngine;
using System.Collections;

public class InstantVelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;
	private Rigidbody2D rigidBody2d;

	void Awake () {
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidBody2d.velocity = velocity;
	}
}
