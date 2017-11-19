using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPuzzle : MonoBehaviour {
	[SerializeField]
	private Sprite imagen;

	public List<Button> btns= new List<Button>();
	void Awake(){

	}

	void GetBoton(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("puxxle");
		for (int i = 0; i < objects.Length; i++) {
			btns.Add (objects [i].GetComponent<Button> ());
			btns [i].image.sprite = imagen;
		
		}
	}
}
