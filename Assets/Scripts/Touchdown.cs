using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchdown : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "Jogador") {
			print ("TOUCH DOWWWWWN");
		}
	}
}
