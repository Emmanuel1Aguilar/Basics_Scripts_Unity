using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
	public Transform Player;
	public float suavizado= 5f;
	Vector3 desface;


	// Use this for initialization
	void Start () {
		desface = transform.position - Player.position;
	}
	
	void FixedUpdate(){
		Vector3 posicionPlayer = Player.position + desface;
		transform.position = Vector3.Lerp (transform.position,posicionPlayer,suavizado*Time.deltaTime);
	}
}
