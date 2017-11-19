using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

	[SerializeField]
	private Transform puzzle;
	[SerializeField]
	private GameObject btn;

	void Awake (){
		for (int i = 0; i < 0; i++) {
			GameObject boton = Instantiate (btn);
			boton.name="" + i;
			boton.transform.SetParent (puzzle, false);
		}
	}
}
