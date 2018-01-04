using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toquesNaTela : MonoBehaviour {

	int toquesQtd = 0;
	public Text texto;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		toquesQtd = Input.touchCount;
		texto.text = toquesQtd.ToString();
	}
}
