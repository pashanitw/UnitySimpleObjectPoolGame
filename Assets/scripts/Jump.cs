using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {


	public float jumpSpeed = 240f;
	public Rigidbody2D body2d;
	public InputState inputState;
	public float forwardSpeed = 20f;
	// Use this for initialization
	void Awake () {
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}

	void Update () {
		if (inputState.standing) {
			if(inputState.actionButton){
				body2d.velocity = new Vector2(transform.position.x<0 ? forwardSpeed : 0, jumpSpeed);
			}
		}
	}
}
