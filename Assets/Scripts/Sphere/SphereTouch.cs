using UnityEngine;
using UnityEngine.Events;

public class SphereTouch : MonoBehaviour {

	[SerializeField]
	private UnityEvent onTouch;

	public void DoTouch(){

		this.onTouch.Invoke();
	}

	void OnMouseDown(){

		this.DoTouch();
	}
}