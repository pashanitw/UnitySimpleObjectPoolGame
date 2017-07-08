using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IRecycle {
	void Restart ();
	void ShutDown ();
}

public class RecycleGameObject : MonoBehaviour {
	private List<IRecycle> recycleComponets = new List<IRecycle>();

	void Awake(){
		var components = GetComponents<MonoBehaviour> ();
		foreach (var component in components) {
			if(component is IRecycle){
				recycleComponets.Add(component as IRecycle);
			}
		}
	}

	public void Restart() {
		gameObject.SetActive (true);
		foreach (var component in recycleComponets) {
			component.Restart();
		}
	}

	public void ShutDown(){
		gameObject.SetActive (false);
		foreach (var component in recycleComponets) {
			component.ShutDown();
		}
	}
}
