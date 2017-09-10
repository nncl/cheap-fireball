using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour {

	public float velocidade, alturaY;
	public int vidas;
	public Text txtVidas;
	Vector2 posicaoInicial;

	void Start () {
		// Remove gravidade
		GetComponent<Rigidbody2D> ().gravityScale = 0.0f;
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;

		posicaoInicial = transform.position;
	}
	
	void Update () {

		txtVidas.text = vidas.ToString ();
		
		if (Input.GetButton("Fire1")) {
			Vector2 posicaoMouse = Input.mousePosition;
			posicaoMouse = Camera.main.ScreenToWorldPoint (posicaoMouse);

			posicaoMouse = new Vector2 (posicaoMouse.x, posicaoMouse.y + 1.0f);
			transform.position = Vector2.Lerp (transform.position, posicaoMouse, velocidade * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Inimigo") {
			print ("Bateu no inimigo");
			GetComponent <Collider2D> ().enabled = false;
			vidas--;

			print ("Vidas " + vidas);

			transform.position = posicaoInicial;
			StartCoroutine (Invencivel());

			if (vidas == 0) {
				Sair ();
			}
		}
	}

	IEnumerator Invencivel(){
		for (int x = 0; x <= 3; x++) {
			yield return new WaitForSeconds (1.0f);

			if (GetComponent<SpriteRenderer> ().enabled) {
				GetComponent<SpriteRenderer> ().enabled = false;
			} else {
				GetComponent<SpriteRenderer> ().enabled = true;
			}
		}

		GetComponent<SpriteRenderer> ().enabled = true;
		GetComponent<Collider2D> ().enabled = true;
	}

	void Sair(){
		SceneManager.LoadScene ("Start");
	}
}
