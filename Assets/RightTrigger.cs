using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTrigger : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.RightCheck = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.RightCheck = false;
		}
	}
}
