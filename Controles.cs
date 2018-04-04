using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			if (GetComponent<SpriteRenderer> ().flipX == true) {
				GetComponent<SpriteRenderer> ().flipX = false;
			}

			GetComponent<Animator> ().SetBool ("Caminar", true);
			transform.Translate (0.15f, 0, 0);
		}

		if (Input.GetKey (KeyCode.A)) {
			if (GetComponent<SpriteRenderer> ().flipX == false) {
				GetComponent<SpriteRenderer> ().flipX = true;
			}
			GetComponent<Animator> ().SetBool ("Caminar", true);
			transform.Translate (-0.15f, 0, 0);
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			GetComponent<Animator> ().SetBool ("Caminar", false);
			
		}

		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.RightShift)) {
			GetComponent<Animator> ().SetBool ("Correr", true);
			GetComponent<Animator> ().SetBool ("Caminar", false);
			transform.Translate (0.15f, 0, 0);

		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.RightShift)) {
			GetComponent<Animator> ().SetBool ("Correr", false);
		}
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.RightShift)) {
			GetComponent<Animator> ().SetBool ("Correr", true);
			GetComponent<Animator> ().SetBool ("Caminar", false);
			transform.Translate (-0.15f, 0, 0);

		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.RightShift)) {
			GetComponent<Animator> ().SetBool ("Correr", false);
		}
		}



			
}



