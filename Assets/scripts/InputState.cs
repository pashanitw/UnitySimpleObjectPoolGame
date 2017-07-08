using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

	public bool actionButton;
	public float absVelX=0f;
	public float absVelY=0f;
	public bool standing;
	public float stadingThreshold =1f;

	private Rigidbody2D rigidBody2d;

	void Awake(){
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		actionButton = Input.anyKey;
	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (rigidBody2d.velocity.x);
		absVelY = System.Math.Abs (rigidBody2d.velocity.y);
		standing = absVelY <= stadingThreshold;
	}
}
