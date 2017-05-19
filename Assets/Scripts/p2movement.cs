using UnityEngine;
using System.Collections;

public class p2movement : MonoBehaviour {

	public float speed = 110f; 
	public float boostSpeed = 250f;
	public float turnSpeed = 3.5f; 
	public float hoverForce = 65f; 
	public float hoverHeight = 3.5f;

	private float powerInput;
	private float turnInput;
	private float boostInput;
	private Rigidbody carRigidbody; 

	void Awake () {
		carRigidbody = GetComponent <Rigidbody>();
	}
	
	void Update () {
		powerInput = Input.GetAxis ("Verticalp2");
		turnInput = Input.GetAxis ("Horizontalp2");
		boostInput = Input.GetAxis ("Boostp2");
	}

	void FixedUpdate () {
		Ray ray = new Ray (transform.position, -transform.up);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, hoverHeight)) {
			float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
			Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverForce;
			carRigidbody.AddForce(appliedHoverForce, ForceMode.Acceleration);
		}

		carRigidbody.AddRelativeForce(0f, 0f, powerInput * speed);
		carRigidbody.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);
		carRigidbody.AddRelativeTorque(0f, 0f, boostInput * boostSpeed);
	}
}
