using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class scriptplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void CargaEscenario(string escenario1)
    {
        SceneManager.LoadScene (escenario1);

    }
		
	public void pruebaCanvas2 (){
		GetComponent<Canvas> ().enabled = true;

	}
}