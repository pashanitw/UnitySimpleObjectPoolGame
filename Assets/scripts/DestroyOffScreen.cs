using UnityEngine;
using System.Collections;

public class DestroyOffScreen : MonoBehaviour {

	private Rigidbody2D rigidBody2D;
	private int padding = 32;

	void Start () {
		//print ("world units are"+(Screen.width / PixelPerfect.pixelsToUnit));
		//print ("pixel to units are"+ PixelPerfect.pixelsToUnit);
	}
	
	// Update is called once per frame
	void Update () {
		var posX = transform.position.x;
		var worldUnits = Screen.width / PixelPerfect.pixelsToUnit;
		var halfWorldUnits = worldUnits / 2;

		if (posX < 0 && (Mathf.Abs (posX) > (halfWorldUnits+padding))) {
			print ("half world units"+halfWorldUnits+","+(halfWorldUnits+padding)+","+posX);
			//DestroyObject(gameObject);
			GameObjectUtil.Destroy(gameObject);
		}
	}

}
