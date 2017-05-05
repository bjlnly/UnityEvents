using UnityEngine;
using UnityEngine.Events;

public class MyComputer : MonoBehaviour {

	private float _value1;
	private float _value2;

	[SerializeField]
	private PassString onAdd;
	[SerializeField]
	private PassString onSubtract;
	[SerializeField]
	private PassString onMultiply;
	[SerializeField]
	private PassString onDivide;
	[SerializeField]
	private UnityEvent onResetStatus;

	public string value1{
		set{
			float.TryParse(value , out this._value1);
		}
	}

	public string value2{
		set{
			float.TryParse(value , out this._value2);
		}
	}

	public void Add(){

		this.onAdd.Invoke((this._value1 + this._value2).ToString());
	}

	public void Subtract(){
		
		this.onSubtract.Invoke((this._value1 - this._value2).ToString());
	}

	public void Multiply(){
		
		this.onMultiply.Invoke((this._value1 * this._value2).ToString());
	}

	public void Divide(){
		if(this._value2 == 0) return;
		this.onDivide.Invoke((this._value1 / this._value2).ToString());
	}

	public void ResetStatus(){

		this.onResetStatus.Invoke();
	}
}