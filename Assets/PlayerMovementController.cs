using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
	public float movespeed;
	public float jumpspeed;
	public Rigidbody2D rb;
	public static bool isGrounded = false;
	public static bool LeftCheck = false;
	public static bool RightCheck = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {

		//leftcheck, rightcheck, and isgrounded mean they're in the collider/intersecting

		if (isGrounded && Input.GetKeyDown(KeyCode.Space)) {
			rb.velocity = new Vector3 (rb.velocity.x, jumpspeed, 0);
		}

		if (Input.GetKey(KeyCode.A)) {
			rb.velocity = new Vector2 (-movespeed, rb.velocity.y);
		}
		if (Input.GetKeyUp(KeyCode.A)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.D)) {
			rb.velocity = new Vector2 (movespeed, rb.velocity.y);
		}
		if (Input.GetKeyUp(KeyCode.D)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (LeftCheck && Input.GetKey(KeyCode.A)) {
			rb.velocity = new Vector3 (rb.velocity.x, -0.6f, 0);
		} else if (RightCheck && Input.GetKey(KeyCode.D)) {
			rb.velocity = new Vector3 (rb.velocity.x, -0.6f, 0);
		}

		if (LeftCheck && Input.GetKeyDown(KeyCode.Space)) {
			rb.velocity = new Vector3 (3.0f, jumpspeed, 0);
		} else if (RightCheck && Input.GetKeyDown(KeyCode.Space)) {
			rb.velocity = new Vector3 (-3.0f, jumpspeed, 0);
		}








//		int horizontal = 0;
//		int vertical = 0;
//
//		if (Input.GetKey(KeyCode.A))
//		{
//			horizontal--;
//		}
//		if (Input.GetKey(KeyCode.D))
//		{
//			horizontal++;
//		}
//		rb.velocity = new Vector3(horizontal * movespeed, rb.velocity.y, 0);
//
////		if (Input.GetKeyUp(KeyCode.A)) {
////			LeftCheck = false;
////		}
////		if (Input.GetKeyUp(KeyCode.D)) {
////			RightCheck = false;
////		}
//
////		if (Input.GetKeyDown(KeyCode.Space) && (isGrounded) && !LeftCheck && !RightCheck)
//		if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
//		{
//			vertical++;
//			rb.velocity = new Vector3(rb.velocity.x, vertical * jumpspeed, 0);
//			isGrounded = false;
//		}
//
//		if (LeftCheck && Input.GetKey(KeyCode.A))
//		{
//			rb.velocity = new Vector3(rb.velocity.x, -0.6f, 0);
//			if (Input.GetKeyDown(KeyCode.Space))
//			{
//				rb.velocity = new Vector3(3, jumpspeed, 0);
//				LeftCheck = false;
//			}
//		}
//		if (RightCheck && Input.GetKey(KeyCode.D))
//		{
//			rb.velocity = new Vector3(rb.velocity.x, -0.6f, 0);
//			if (Input.GetKeyDown(KeyCode.Space))
//			{
//				rb.velocity = new Vector3(-3, jumpspeed, 0);
//				RightCheck = false;
//			}
//		}

		Camera.main.transform.position = transform.position + new Vector3(0, 0, -10);
	}
}