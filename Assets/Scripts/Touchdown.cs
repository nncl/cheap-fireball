using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touchdown : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "Jogador") {
			print ("TOUCH DOWWWWWN");
			SceneManager.LoadScene ("Final");
		}
	}
}
