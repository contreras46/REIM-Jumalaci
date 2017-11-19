using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Splash : MonoBehaviour {
	public float start = 0.0f;
	public float end = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		start += Time.deltaTime;
		if (start >= end) {
			SceneManager.LoadScene (1);
		}
	}
}
