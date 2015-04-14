using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour 
{


	/*
	public float speed;
	public float thrust;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		rb.AddForce(moveHorizontal*speed, 0.0f, moveVertical*speed);
	} */

	public float speed;
	public Rigidbody rb;
	private int count;
	public GUIText countText;
	public GUIText winText;

	void Start() {
		rb = GetComponent<Rigidbody> ();

		count = 0;
		SetCountText();
		winText.text = "";
		System.Diagnostics.Debug.WriteLine("Hello");
		Console.WriteLine ("hellou");


	}
	
	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (moveHorizontal*speed*Time.deltaTime,0.0f,moveVertical*speed*Time.fixedDeltaTime); 
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);
			count= count + 1;
			SetCountText();
			Console.WriteLine ("hellou");
		}

	}

	void SetCountText(){
		System.Diagnostics.Debug.WriteLine (count.ToString());
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "YOU WIN";
		}
	}


}