using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNext : MonoBehaviour {

	public GameObject[] Levels;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			int rand = Random.Range (0, Levels.Length);

			float thisHeight = gameObject.GetComponentInParent<SpriteRenderer> ().bounds.size.y/2;
			float otherHeight = Levels [rand].GetComponent<SpriteRenderer> ().bounds.size.y / 2;
			GameObject newObj = (GameObject)Instantiate (Levels [rand], transform.parent.transform.position + new Vector3 (0, thisHeight + otherHeight, 0), Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
