using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour , IDropHandler, IPointerEnterHandler, IPointerExitHandler{

	public void OnPointerEnter (PointerEventData eventData){
		//Debug.Log ("OnPointerEnter" );
		if (eventData.pointerDrag == null) { // if nothing drag nth will happen
			return;
		}
		Drag d = eventData.pointerDrag.GetComponent<Drag> ();
		if (d != null) {
			d.placeholderParent = this.transform; //overwrite the tabletop
		}
	}

	public void OnPointerExit (PointerEventData eventData){
		//Debug.Log ("OnPointerExit" );
		if (eventData.pointerDrag == null) { //if nothing drag nth will happen
			return;
		}
		Drag d = eventData.pointerDrag.GetComponent<Drag> ();
		if (d != null && d.placeholderParent==this.transform) {
			d.placeholderParent = d.parentToReturnTo; //return to where we start from
		}
	}

	public void OnDrop (PointerEventData eventData){
		Debug.Log (eventData.pointerDrag.name + "was dropped on " + gameObject.name);

		//only if drop in somewhere legal
		Drag d = eventData.pointerDrag.GetComponent<Drag> ();
		if (d != null) {
			d.parentToReturnTo = this.transform; //overwrite the tabletop
		}
	}
}
