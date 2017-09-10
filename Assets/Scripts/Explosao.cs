using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour {

	public float intervalo;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, intervalo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
