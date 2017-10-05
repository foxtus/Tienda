
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tendero : MonoBehaviour {
	[SerializeField] InterfazGrafica tienda;
	bool trigger;
	// Use this for initialization
	void Start () {
		trigger = false;

	}

	// Update is called once per frame
	void Update () {
		if (trigger) {

			if (Input.GetKeyDown(KeyCode.P)) {
				tienda.BotonPausa();
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Cubo")){
			trigger = true;
		}
	}

	void OnTriggerExit(Collider col){
		if(col.CompareTag("Cubo")){
			trigger = false;
		}
	}
}
