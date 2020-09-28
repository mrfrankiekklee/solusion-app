using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeA : MonoBehaviour {
	public GameObject mixSolution;
	public Material elementAColor;
	Renderer rend;



	private bool elementA = false;
	// Use this for initialization
	void Start () {

		}

	
	// Update is called once per frame
	void Update () {
		
	}

	public bool isElementAActive() {
		return elementA;
	
	}

	public void setElementA(bool state) {
		elementA = state;
	}



}
