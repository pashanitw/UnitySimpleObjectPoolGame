using UnityEngine;
using System.Collections;

public class PixelPerfect : MonoBehaviour {
	public static float pixelsToUnit = 1f;
	public static float scale=1f;
	public static Vector2 nativeResolution = new Vector2(240, 160);

	void Awake(){
		print ("inside awake");
		var camera = GetComponent<Camera> ();
		print (camera.orthographicSize);
		if (camera.orthographic) {
			scale=Screen.height/nativeResolution.y;
			pixelsToUnit*=scale;
			camera.orthographicSize=(Screen.height/2.0f)/pixelsToUnit;
			print ("after awake");
			print (camera.orthographicSize);
		}

	}


}
