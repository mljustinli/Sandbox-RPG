using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

	private int hp;

	private Vector3 targetPos;

	// Use this for initialization
	void Start () {
		hp = 10;

		targetPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}

		Vector3 pos = transform.position;
		transform.position = Vector3.Lerp (pos, targetPos, 1.0f * Time.deltaTime);
		transform.position = new Vector3 (transform.position.x, transform.position.y, 0);

	}
}
