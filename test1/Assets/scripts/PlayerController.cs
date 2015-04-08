using UnityEngine;
using System.Collections;

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

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (moveHorizontal*speed*Time.deltaTime,0.0f,moveVertical*speed*Time.fixedDeltaTime); 
	}

}
