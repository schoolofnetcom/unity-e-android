using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeObj : MonoBehaviour {

	public GameObject cubo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			
			RaycastHit hit;
			Ray position = Camera.main.ScreenPointToRay(Input.GetTouch (0).position);

			if(Physics.Raycast(position, out hit)){

				Instantiate (cubo, hit.point, transform.rotation);

			}

		}
			
	}
}
