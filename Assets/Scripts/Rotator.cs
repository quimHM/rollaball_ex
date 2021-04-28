using UnityEngine;

public class Rotator : MonoBehaviour {

	private float phase;
	public bool moving;

	void Start(){
		phase = Mathf.Atan(transform.position.y/transform.position.x);
		if (transform.position.x < 0){phase+=Mathf.PI;}
	}

	void Update () 
	{
		if (moving) transform.position = new Vector3 (8*Mathf.Cos(Time.time+phase),0.5f,8*Mathf.Sin(Time.time+phase));
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	