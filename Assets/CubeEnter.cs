using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) { 

		if (other.gameObject.CompareTag ("selected")) {
			//Destroy(other.gameObject);
			Debug.Log("Entered");

			other.attachedRigidbody.MovePosition (this.transform.position);

		}
//				if(other.gameObject.CompareTag("the_tag_which_you_kept_earlier") 
//					{ other.rigidbody.MovePosition(transform.position); }
	}
}
