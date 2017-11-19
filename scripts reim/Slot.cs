using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

	public GameObject Item{
        get{
			Debug.Log (transform.parent.childCount);
			if (transform./*parent.*/childCount > 0){
				Debug.Log ("Hola > " + transform.name);
                return transform./*parent.*/GetChild(0).gameObject;
            }
            return null;


        }
    }

    public void OnDrop(PointerEventData eventData){
        if (!Item){
			DragHandeler.itemBeginDragged.transform.SetParent(transform);
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject,null,(x,y)=> x.HasChanged());
        }
    }


}


