using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
	//http://docs.unity3d.com/ScriptReference/Transform-rotation.html
	// Smoothly tilts a transform towards a target rotation.
	public float smooth;
	public float tiltAngle;

	void FixedUpdate () {
		float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle * Time.deltaTime;
		float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle * Time.deltaTime;
		var target = Quaternion.Euler (tiltAroundX, 0, tiltAroundZ);

		// Dampen towards the target rotation
		rigidbody.MoveRotation(rigidbody.rotation * target);
	}
}
