using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectUtil{

	private static Dictionary<RecycleGameObject, ObjectPool> pools = new Dictionary<RecycleGameObject, ObjectPool> ();

	public static GameObject Instantiate(GameObject prefab, Vector3 pos){
		GameObject instance = null;
		var recycledScript = prefab.GetComponent<RecycleGameObject> ();
		if (recycledScript) {
			var pool = GetObjectPool (recycledScript);
			var poolObject = pool.NextObject (pos);
			instance = poolObject.gameObject;
		} else {
			instance = GameObject.Instantiate (prefab);
			instance.transform.position = pos;
		}
		return instance;
	}

	public static void Destroy(GameObject prefab){
		var recycleGameObject = prefab.GetComponent<RecycleGameObject> ();
		if (recycleGameObject != null) {
			recycleGameObject.ShutDown ();
		} else {
			GameObject.Destroy (prefab);
		}
	}

	private static ObjectPool GetObjectPool(RecycleGameObject reference){
		ObjectPool pool = null;
		if (pools.ContainsKey (reference)) {
			return pools [reference];
		} else {
			GameObject poolContainer = new GameObject(reference.gameObject.name+"ObjectPool");
			pool = poolContainer.AddComponent<ObjectPool>();
			pool.prefab = reference;
			pools.Add (reference, pool);
		}
		return pool;
	}
} 
