using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {

	//private Rigidbody rb;

	//public int count;

	// Use this for initialization
	void Start () {
		//rb.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) { 
		//Destroy(other.gameObject);
		if (other.gameObject.CompareTag ("EnterRegion")) {
//			count++;
//			Debug.Log (count);
			Debug.Log("Enter");
		}
	}
}
