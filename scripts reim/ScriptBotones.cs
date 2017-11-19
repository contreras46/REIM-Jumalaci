using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBotones : MonoBehaviour {

    private float velMov = 5f;
    private float velGiro = 50f;
    public bool avanzar = false;
    private bool girarDer = false;
    private bool girarIzq = false;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (avanzar == true)
        {
            transform.Translate(Vector3.forward * velMov * Time.deltaTime);
        }
        if (girarIzq == true)
        {
            transform.Translate(Vector2.left * velGiro * Time.deltaTime);
        }
        else if (girarDer)
        {
            transform.Translate(Vector2.right * velGiro * Time.deltaTime);
        }
	}

    public void Avanzar()
    {
        avanzar = true;
    }

    public void dejarDeAvanzar()
    {
        avanzar = false;
    }

    public void GirarIzq()
    {
        girarIzq = true;
    }

    public void GirarDer()
    {
        girarDer = true;
    }

    public void DejarDeGirar()
    {
        girarDer = false;
        girarIzq = false;
    }
}
