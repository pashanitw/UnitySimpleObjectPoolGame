using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour,IRecycle {

	public Sprite[] sprites;
	public Vector2 colliderOffset = Vector2.zero;

	public void Restart(){
		var renderer = GetComponent<SpriteRenderer> ();
		renderer.sprite = sprites [Random.Range (0, sprites.Length)];
		var collider = GetComponent<BoxCollider2D> ();
		var size = renderer.bounds.size;
		collider.size = size;
		collider.offset = new Vector2 (0, size.y / 2);
	} 

	public void ShutDown() {

	}
}
