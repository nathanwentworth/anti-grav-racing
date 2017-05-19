using UnityEngine;
using System.Collections;

public class carTilt : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) 
			transform.Rotate(0, 0, 300 * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.D))
			transform.Rotate(0, 0, -300 * Time.deltaTime);
		if (Input.GetKeyUp(KeyCode.A)) 
			transform.Rotate(0, 0, -300 * Time.deltaTime);
		if (Input.GetKeyUp(KeyCode.D))
			transform.Rotate(0, 0, 300 * Time.deltaTime);
	}
}
