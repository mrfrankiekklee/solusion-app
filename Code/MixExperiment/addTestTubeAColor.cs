using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTestTubeAColor : MonoBehaviour {
	public GameObject mixSolution;
	public Material elementAColor;
	Renderer rend;


	public void addColortoMix(){

		elementAColor = this.GetComponent<Renderer> ().material;
		rend = mixSolution.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = elementAColor;

}
}