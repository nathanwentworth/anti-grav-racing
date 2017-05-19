using UnityEngine;
using System.Collections;

public class finishScript : MonoBehaviour {

	private int pOneLaps = 0;
	private int pTwoLaps = 0;
	private Rigidbody carRigidbody; 

	// Update is called once per frame
	private int OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player1")) {
			pOneLaps += 1;
			Debug.Log(pOneLaps);
			return pOneLaps;
		}
		else if (other.CompareTag("Player2")) {
			pTwoLaps += 1;
			return pTwoLaps;
		}
		else {

		}
		return 0;
	}
}
