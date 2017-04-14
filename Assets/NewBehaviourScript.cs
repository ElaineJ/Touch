using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	Vector2 floatY;
	float originalY;
	public float floatStrength = (float)0.25;
	// Use this for initialization
	void Start () {
		
		this.originalY = this.transform.position.y;

	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,
			originalY + ((float)System.Math.Sin(Time.time) * floatStrength),
			transform.position.z);
	}
}