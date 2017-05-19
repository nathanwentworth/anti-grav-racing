using UnityEngine;
using System.Collections;

public class car2Tilt : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) 
			transform.Rotate(0, 0, 300 * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.RightArrow))
			transform.Rotate(0, 0, -300 * Time.deltaTime);
		if (Input.GetKeyUp(KeyCode.LeftArrow)) 
			transform.Rotate(0, 0, -300 * Time.deltaTime);
		if (Input.GetKeyUp(KeyCode.RightArrow))
			transform.Rotate(0, 0, 300 * Time.deltaTime);
	}
}
