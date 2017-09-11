using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touchdown : MonoBehaviour {
	void Start(){
		gameObject.SetActive (false);
		Invoke ("DisplayTouchdown", 2.0f);
	}

	void DisplayTouchdown(){
		gameObject.SetActive (true);
	}

	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "Jogador") {
			print ("TOUCH DOWWWWWN");
			SceneManager.LoadScene ("Final");
		}
	}
}
