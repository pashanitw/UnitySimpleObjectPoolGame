using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour {

	// Use this for initialization
	public int textureSize = 32;
	public bool scaleVertically=true;
	public bool scaleHorizontally = true;
	void Start () {

		var scale = PixelPerfect.scale;
		var newWidth =!scaleHorizontally ? 1: Mathf.Ceil(Screen.width / (scale * textureSize));
		var newHeight =!scaleVertically ?1: Mathf.Ceil(Screen.height / (scale * textureSize));
		transform.localScale = new Vector3 (newWidth*textureSize, newHeight*textureSize, 1);
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
