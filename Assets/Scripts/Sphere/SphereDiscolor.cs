using UnityEngine;

public class SphereDiscolor : MonoBehaviour {

	private Material _material;
	private Color _color;

	[SerializeField]
	private Color color = Color.white;

	[SerializeField]
	private PassColor onChangeColor;
	[SerializeField]
	private PassColorReturn onSwapColor;

	void Awake(){

		this._material = GetComponent<Renderer>().material;
		this.DefaultColor();
	}

	public void DefaultColor(){

		this._material.color = this.color;
		this._color = this.color;
	}

	public void Discolor(Color color){

		this._material.color = color;
		this._color = color;
		this.onChangeColor.Invoke(color);
	}

	public void RandomColor(){

		this.Discolor(new Color(Random.value , Random.value , Random.value));
	}

	public void SwapColor(){

		PassHolder holder = new PassHolder();
		this.onSwapColor.Invoke(this._color , holder);
		this.Discolor(holder.GetValue<Color>());
	}

	public void Discolor(Color color , PassHolder holder){

		holder.value = this._color;
		this.Discolor(color);
	}
}