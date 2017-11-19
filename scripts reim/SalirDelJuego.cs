using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SalirDelJuego : MonoBehaviour {

	public void Salir(){
		UnityEngine.Application.Quit ();
		Debug.Log("ya saliste ;D");
   }
}

