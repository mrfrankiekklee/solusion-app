using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getElementB : MonoBehaviour {
	public LoadClassroom call;
	public GameObject testtubeBSolution;
	public Text elementBText;
	Renderer rend;


	// Use this for initialization
	public void callB () {
	//	LoadClassroom.getmixElementB ();

		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		testtubeBSolution =GameObject.Find("test-tube_solutionB");
		elementBText = GameObject.Find ("ElementB_text").GetComponent<Text> ();
		if (testtubeBSolution != null) {
			rend = testtubeBSolution.GetComponent<Renderer> ();
			rend.enabled = true;
			handleElementB ();
		}
			


		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void handleElementB(){
		if (call.getmixElementB () == "water") {
			rend.material = Resources.Load ("Water", typeof(Material)) as Material;
			rend.sharedMaterial = rend.material;
		} else if (call.getmixElementB () == "nitrogen") {
			rend.material = Resources.Load ("seethrough", typeof(Material)) as Material;
			rend.sharedMaterial = rend.material;
		}
	}


}
