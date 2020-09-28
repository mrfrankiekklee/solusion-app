using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getElementA : MonoBehaviour {
	public LoadClassroom call;
	public GameObject testtubeASolution;
	public Text elementAText;
	Renderer rend;


	// Use this for initialization
	public void callA () {
	//	LoadClassroom.GetmixElementA ();

		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		testtubeASolution =GameObject.Find("test-tube_solutionA");
		elementAText = GameObject.Find ("ElementA_text").GetComponent<Text> ();
		if (testtubeASolution != null) {
			rend = testtubeASolution.GetComponent<Renderer> ();
			rend.enabled = true;
			handleElementA ();
		}
			


		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void handleElementA(){
		if (call.getmixElementA () == "water") {
			rend.material = Resources.Load ("Water", typeof(Material)) as Material;
			rend.sharedMaterial = rend.material;
		} else if (call.getmixElementA () == "nitrogen") {
			rend.material = Resources.Load ("seethrough", typeof(Material)) as Material;
			rend.sharedMaterial = rend.material;
		}
	}


}
