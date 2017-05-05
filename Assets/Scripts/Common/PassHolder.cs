
public class PassHolder {

	public object value{set; private get;}

	public T GetValue<T>(){

		if(this.value == null) return default(T);

		return (T)this.value;
	}
}