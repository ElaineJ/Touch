using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2 : MonoBehaviour
{

	//public Transform parentToReturnTo = null;
	Vector3 startPosition;
	int count = 0;
	Vector3 dist;
	float posX;
	float posY;



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





	}
	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.CompareTag("CubeRegion"))
		{
			//Destroy(other.gameObject);
			Debug.Log("Enter");
			count++;
			Debug.Log(count);

		}
	}

	void OnMouseUp()
	{
		Debug.Log("UP");
		//transform.position = dist;

		if (startPosition.y < -2 && this.transform.position.y < -2)
		{
			gameObject.transform.position = startPosition;
		}

		//  if (startPosition.y > -2) {
		//   this.transform.position.y = -3.769989;
		//  }
		//gameObject.transform.position = originalPosition;


	}

//	void Update()
//	{
//		if (count == 1)
//		{
//			gameObject.tag = "selected";
//		}
//	}

}