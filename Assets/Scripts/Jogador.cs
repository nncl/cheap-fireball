using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public float velocidade, alturaY;

	void Start () {
		// Remove gravidade
		GetComponent<Rigidbody2D> ().gravityScale = 0.0f;
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
	}
	
	void Update () {
		if (Input.GetButton("Fire1")) {
			Vector2 posicaoMouse = Input.mousePosition;
			posicaoMouse = Camera.main.ScreenToWorldPoint (posicaoMouse);

			posicaoMouse = new Vector2 (posicaoMouse.x, posicaoMouse.y + 1.0f);
			transform.position = Vector2.Lerp (transform.position, posicaoMouse, velocidade * Time.deltaTime);
		}
	}
}
