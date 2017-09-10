using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigos : MonoBehaviour {

	public GameObject inimigoPrefab;
	public float limiteEsquerdo, limiteDireito, intervalo;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (intervalo);
		float posicaoX = Random.Range (limiteEsquerdo, limiteDireito);
		Vector2 posicao = new Vector2 (posicaoX, transform.position.y);
		Instantiate (inimigoPrefab, posicao, transform.rotation);
		StartCoroutine (Start());
	}
}
