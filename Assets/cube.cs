using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	public Collider2D coll;
	// Use this for initialization
	void Start () {
		coll = GetComponent<Collider2D> ();
		coll.isTrigger = true;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter2D(Collider2D other){
		if (other.attachedRigidbody) {
			other.attachedRigidbody.gravityScale = 0.0f;
		}
	}
}
