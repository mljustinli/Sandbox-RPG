using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTrigger : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.isGrounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Jumpable") {
			PlayerMovementController.isGrounded = false;
		}
	}
}
