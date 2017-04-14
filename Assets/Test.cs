using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Test : MonoBehaviour {


	//public Transform parentToReturnTo = null;
	Vector3 startPosition;

	Vector3 dist;
	float posX;
	float posY;
	//int count = 0;

	GameObject go;

	void OnMouseDown( ){
		startPosition = this.transform.position;
		Debug.Log ("Down");
		Debug.Log (this.transform.position.x);
		Debug.Log (this.transform.position.y);

		//Vector3 originalPosition = gameObject.transform.position;

		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;


//		parentToReturnTo = this.transform.parent; 
//		this.transform.SetParent (this.transform.root);

	}

	void OnMouseDrag(){

//		Vector3 pos = Vector3.zero;
		//		pos.posX = Mathf.Clamp (pos.posX, -maxX, maxX);

//				pos.x = Input.mousePosition.x;
//				pos.x = Mathf.Clamp (pos.x, -2.4F, 2.4F);
//		
//				pos.y = Input.mousePosition.y;
//				pos.y = Mathf.Clamp (pos.y, -4.4F, 4.6F);
		//Debug.Log ("Drag");
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX , 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		this.transform.position = worldPos;

//		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
//		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
//		transform.position = curPosition;
//		//Snap mode ON
//		if (Input.GetMouseButton(1)) {
//			curPosition.x = (float)(Mathf.Round(curPosition.x / gridSize_x) * gridSize_x);
//			curPosition.y = (float)(Mathf.Round(curPosition.y / gridSize_y) * gridSize_y);
//			curPosition.z = (float)(Mathf.Round(curPosition.z / gridSize_z) * gridSize_z);
//			this.transform.position = curPosition;
//		}

		//clamp the x and y value of the sphere






	}

//	void OnTriggerEnter(Collider other)
//	{
//
//		if (other.gameObject.CompareTag("0"))
//		{
//			gameObject.tag = "b0";
//
//			//other.attachedRigidbody.MovePosition (this.transform.TransformPoint(Collider.bounds.center));
//
//		}
//
//		if (other.gameObject.CompareTag("1"))
//		{
//			gameObject.tag = "b1";
//
//		}
//		if (other.gameObject.CompareTag("2"))
//		{
//			gameObject.tag = "b2";
//
//		}
//		if (other.gameObject.CompareTag("3"))
//		{
//			gameObject.tag = "b3";
//
//		}
//	}

	void OnTriggerEnter2D(Collider2D other) { 
		go = other.gameObject;
//		if (other.gameObject.CompareTag ("CubeRegion")) {
//			
//			//Destroy(other.gameObject);
//
////			count++;
////			Debug.Log ("Count = " + count);
//			//other.transform.position;
//
//			//other.attachedRigidbody.MovePosition (transform.position);
//
//
//			//other.attachedRigidbody.MovePosition (this.transform.TransformPoint(Collider.bounds.center));
//
//		}
		if (other.gameObject.CompareTag ("b0")) {
			gameObject.tag = "0";

			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
			Debug.Log("Enter");
		} else if (other.gameObject.CompareTag ("b1")) {
			gameObject.tag = "1";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
		}
		else if (other.gameObject.CompareTag ("b2")) {
			gameObject.tag = "2";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
		}
		else if (other.gameObject.CompareTag ("b3")) {
			gameObject.tag = "3";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
		}
		else if (other.gameObject.CompareTag ("b4")) {
			gameObject.tag = "4";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
		}
		else if (other.gameObject.CompareTag ("b5")) {
			gameObject.tag = "5";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=0.0f;
		}

//		if(other.gameObject.CompareTag("the_tag_which_you_kept_earlier") 
//			{ other.rigidbody.MovePosition(transform.position); }
	}

	void OnTriggerExit2D(Collider2D other) {
		// Destroy everything that leaves the trigger
		Debug.Log("Exit");
		go = null;
		if (other.gameObject.CompareTag ("b0")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		} else if (other.gameObject.CompareTag ("b1")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		}
		else if (other.gameObject.CompareTag ("b2")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		}
		else if (other.gameObject.CompareTag ("b3")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		}
		else if (other.gameObject.CompareTag ("b4")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		}
		else if (other.gameObject.CompareTag ("b5")) {
			gameObject.tag = "Untagged";
			gameObject.GetComponent<Rigidbody2D>().gravityScale=1.0f;
		}
//



	}

	void OnMouseUp(){
		Debug.Log ("UP");
		//transform.position = dist;
		if (go) 
		{
			this.gameObject.transform.position = go.transform.position;
		}

//		if (startPosition.y <-2 && this.transform.position.y < -2) {
//			gameObject.transform.position = startPosition;
//		}

		if (startPosition.y > -2) {
			//this.transform.position.y = -3.769989;
			Debug.Log("Inside");
		}
		//gameObject.transform.position = originalPosition;


	}
}

//	public Vector3 pointB;
//
//	IEnumerator Start()
//	{
//		var pointA = transform.position;
//		while (true) {
//			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
//			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
//		}
//	}
//
//	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
//	{
//		var i= 0.0f;
//		var rate= 1.0f/time;
//		while (i < 1.0f) {
//			i += Time.deltaTime * rate;
//			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
//			yield return null; 
//		}
//	}


