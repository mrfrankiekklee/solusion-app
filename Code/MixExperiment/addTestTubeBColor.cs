using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTestTubeBColor : MonoBehaviour {
	public GameObject mixSolution;
	public Material elementBColor;
	Renderer rend;


	public void addColortoMix(){

		elementBColor = this.GetComponent<Renderer> ().material;
		rend = mixSolution.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = elementBColor;

	}
}