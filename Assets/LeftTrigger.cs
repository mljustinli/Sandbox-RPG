using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTrigger : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.LeftCheck = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.LeftCheck = false;
		}
	}
}
