using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundo : MonoBehaviour {

	public float limiteY, velocidade;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * velocidade * Time.deltaTime);

		if (transform.position.y <= limiteY) {
			transform.position = new Vector2 (0.0f, limiteY * -1);
		}
	}
}
