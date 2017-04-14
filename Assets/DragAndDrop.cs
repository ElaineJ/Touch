using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class testing : MonoBehaviour
{


	//public Transform parentToReturnTo = null;
	Vector3 startPosition;

	Vector3 dist;
	float posX;
	float posY;
	int count = 0;

	GameObject go;

	void OnMouseDown()
	{
		startPosition = this.transform.position;
		Debug.Log("Down");
		Debug.Log(this.transform.position.x);
		Debug.Log(this.transform.position.y);

		//Vector3 originalPosition = gameObject.transform.position;

		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;


		//  parentToReturnTo = this.transform.parent; 
		//  this.transform.SetParent (this.transform.root);

	}

	void OnMouseDrag()
	{

		//Debug.Log ("Drag");
		Vector3 curPos =
			new Vector3(Input.mousePosition.x - posX,
				Input.mousePosition.y - posY, dist.z);

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		this.transform.position = worldPos;

		//clamp the x and y value of the sphere

	}



	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("b0")) {
			gameObject.tag = "0";
		
			go = other.gameObject;

			other.attachedRigidbody.MovePosition (transform.position);

			//gameObject.tag = "selected";
		}
	}
	void OnTriggerExit(Collider other)
	{

//		if (other.gameObject.CompareTag ("b0")) {
//			go = other.gameObject;
//			gameObject.tag = "Untagged";
//			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
//			other.attachedRigidbody.MovePosition (transform.position);
//		}
		if (other.gameObject.CompareTag("b0"))
		{
			go = other.gameObject;

			other.attachedRigidbody.MovePosition (transform.position);

			//gameObject.tag = "Untagged";
		}
	}
}
//CANCELFORWARD 1 DELETE 1 REPLY
