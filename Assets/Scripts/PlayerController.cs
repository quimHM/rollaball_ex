using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();

		count = 0;

		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float movementX = Input.GetAxis ("Horizontal");
		float movementY = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count += 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Points Collected: " + count.ToString ();
		if (count >= 4) 
		{
			winText.text = "Yey! You Won";
		}
	}
}