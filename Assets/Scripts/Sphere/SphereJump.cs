using UnityEngine;
using System.Collections;

public class SphereJump : MonoBehaviour {

	private enum Status{

		None,
		Moving
	}

	[SerializeField]
	private float hight = 1;
	[SerializeField]
	private float speed = 5;

	private Status _status = Status.None;

	public void Jump(){

		if(this._status == Status.None) StartCoroutine(this.DoJump());
	}

	private IEnumerator Move(Vector3 source , Vector3 target){

		float t = 0;

		while(t < 1){

			transform.position = Vector3.Lerp(source , target , t);
			t += Time.deltaTime * this.speed;

			yield return null;
		}

		transform.position = target;
	}

	private IEnumerator DoJump(){

		this._status = Status.Moving;

		Vector3 source = transform.position;
		Vector3 target = source;
		target.y += this.hight;

		yield return StartCoroutine(this.Move(source , target));
		yield return StartCoroutine(this.Move(target , source));

		this._status = Status.None;
	}
}