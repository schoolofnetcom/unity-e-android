using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toqueBegan : MonoBehaviour {
	public GameObject cubo;
	int valor = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
			Instantiate (cubo, new Vector3 (valor, valor, valor), Quaternion.identity);
			valor += 1;
		}
	}
}
