using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour {

	public float intervalo;

	void Start () {
		Destroy (gameObject, intervalo);
	}
}
