using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTouch2 : MonoBehaviour {
    private Touch touch;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        touch = Input.GetTouch(0);
        float x = -2.5f + 16 * touch.position.x /Screen.width;
        float y = -1.5f + 10 * touch.position.y /Screen.height;

        transform.position = new Vector3(x, y, 0);
    }
}
//no entendi lo que queria si tocar el cuadrado desde lejos y que se moviera o que ? no me sirve este script