using UnityEngine;
using System.Collections;


//OBSOLETE AS OF 11/22/14
public class PlayerController : MonoBehaviour {
	public float speed;

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
}
