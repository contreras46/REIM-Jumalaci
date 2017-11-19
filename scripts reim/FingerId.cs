using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerId : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        foreach (Touch touch in Input.touches)
        {
            string texto = "";
            
            texto += "TOQUE :  " + touch.fingerId + " \n";    // alt signo de interrogacion al lado del cero para el \ xd
            //SIRVE PARA IDENTIFICAR CUANTOS TOUCH HAY EN PANTALLA DE UNA SOLA VEZ

            texto += "TAPCOUNT :  " + touch.tapCount + " \n";
            //CONTADOR DE TOUCH RAPIDOS

            texto += "PHASE :  " + touch.phase.ToString() + " \n";
            //INDICA SI EL DEDO ESTA ESTATICO O EN MOVIMIENTO

            texto += "POSICION X :  " + touch.position.x + " \n";
            //INDICA LA POSICION EN EL EJE X DEL DEDO EN PANTALLA

            texto += "POSICION Y :  " + touch.position.y + " \n";
            //INDICA LA POSICION EN EL EJE Y DEL DEDO EN PANTALLA

            int num = touch.fingerId;
            GUI.Label(new Rect(0 + 170 * num, 20, 500, 300), texto);
            //MUESTRA EN PANTALLA CON LA UBICACION ENTREGADA
        }
    }
}
//SUPORT HASTA 5 TOQUES DE UNA VEZ