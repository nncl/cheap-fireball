using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

	public GameObject explosaoPrefab;
	float velocidade;
	int vidas;

	void Start () {
		velocidade = Random.Range (0.1f, 0.3f);
		GetComponent<Rigidbody2D> ().gravityScale = Random.Range(0.1f, 0.5f);
	}
	
	void OnCollisionEnter2D (Collision2D c) {
		if (c.gameObject.tag == "Jogador") {
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
