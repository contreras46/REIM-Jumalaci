using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTouch : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
        speed = 0.3f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.touchCount == 1)
        {
            transform.Translate(Input.touches[0].deltaPosition.x * speed, Input.touches[0].deltaPosition.y * speed, 0);
        }
	}
}
