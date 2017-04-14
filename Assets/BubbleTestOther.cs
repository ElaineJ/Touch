using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleTestOther : MonoBehaviour {


	Vector3 startPosition;
	//int count = 0;
	Vector3 dist;
	//float posX;
	//float posY;


	GameObject go;
	void OnMouseDown()
	{
		startPosition = this.transform.position;
		Debug.Log("Down");
		Debug.Log(this.transform.position.x);
		Debug.Log(this.transform.position.y);

		//Vector3 originalPosition = gameObject.transform.position;

		dist = Camera.main.WorldToScreenPoint(transform.position);
		//posX = Input.mousePosition.x - dist.x;
		//posY = Input.mousePosition.y - dist.y;


		//  parentToReturnTo = this.transform.parent; 
		//  this.transform.SetParent (this.transform.root);

	}

	void OnMouseDrag(){
		Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		point.x = Mathf.Clamp(point.x, -2.5f, 2.5f);
		//point.y = transform.position.y;
		point.y = Mathf.Clamp(point.y, -4.3f, 4.3f);
		point.z = transform.position.z;
		transform.position = point; 
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		go = other.gameObject;

		if (other.gameObject.CompareTag("b0"))
		{
			gameObject.tag = "0";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;

			//			go = other.gameObject;
			//
			//			other.attachedRigidbody.MovePosition (transform.position);

			//gameObject.tag = "selected";
		}

		else if (other.gameObject.CompareTag("b1"))
		{
			gameObject.tag = "1";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;

			//			go = other.gameObject;
			//
			//			other.attachedRigidbody.MovePosition (transform.position);


		}

		else if (other.gameObject.CompareTag("b2"))
		{
			gameObject.tag = "2";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;

			//			go = other.gameObject;
			////
			//			other.attachedRigidbody.MovePosition (transform.position);


		}

		else if (other.gameObject.CompareTag("b3"))
		{
			gameObject.tag = "3";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;

			//			go = other.gameObject;
			////
			//			other.attachedRigidbody.MovePosition (transform.position);
			////

		}

		else if (other.gameObject.CompareTag("b4"))
		{
			gameObject.tag = "4";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
			//
			//			go = other.gameObject;
			//			//
			//			other.attachedRigidbody.MovePosition (transform.position);
			//			//

		}

		else if (other.gameObject.CompareTag("b5"))
		{
			gameObject.tag = "5";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;

			//			go = other.gameObject;
			//			//
			//			other.attachedRigidbody.MovePosition (transform.position);
			//			//

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("b0")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			//
			//			other.attachedRigidbody.MovePosition (transform.position);

			//gameObject.tag = "Untagged";
		}
		else if (other.gameObject.CompareTag("b1")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			////
			//			other.attachedRigidbody.MovePosition (transform.position);

			//gameObject.tag = "Untagged";
		}

		else if (other.gameObject.CompareTag("b2")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			////
			//			other.attachedRigidbody.MovePosition (transform.position);
			////
			//gameObject.tag = "Untagged";
		}

		else if (other.gameObject.CompareTag("b3")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			////
			//			other.attachedRigidbody.MovePosition (transform.position);
			////
			//gameObject.tag = "Untagged";
		}

		else if (other.gameObject.CompareTag("b4")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			//			//
			//			other.attachedRigidbody.MovePosition (transform.position);
			//
			//gameObject.tag = "Untagged";
		}

		else if (other.gameObject.CompareTag("b5")){

			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;

			//			go = other.gameObject;
			//			//
			//			other.attachedRigidbody.MovePosition (transform.position);
			//			//
			//gameObject.tag = "Untagged";
		}
	}

	void OnMouseUp()
	{
		Debug.Log("UP");


//		gameObject.transform.position = Vector3(Mathf.Round(currentPos.x),
//			Mathf.Round(currentPos.y),
//			Mathf.Round(currentPos.z));

		//transform.position = dist;

		//		if (startPosition.y < -2 && this.transform.position.y < -2)
		//		{
		//			gameObject.transform.position = startPosition;
		//		}

		//  if (startPosition.y > -2) {
		//   this.transform.position.y = -3.769989;
		//  }
		//gameObject.transform.position = originalPosition;


	}
}
