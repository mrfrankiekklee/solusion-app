using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getHeatElement : MonoBehaviour {
	public LoadClassroom call;
	public GameObject heatSolution;
	public Text heatElementText;
	Renderer rend;


	// Use this for initialization
	public void callHeat () {
		//	LoadClassroom.getmixElementB ();

		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		heatSolution =GameObject.Find("heat-solution");
		heatElementText = GameObject.FindGameObjectWithTag ("heatElementText").GetComponent<Text> ();
		rend = heatSolution.GetComponent<Renderer>();
		rend.enabled = true;
		print ("Heat E is : " + call.getheatElement1());
		handleHeatElement();





	}

	// Update is called once per frame
	void Update () {


	}

	void handleHeatElement(){
		if (call.getheatElement1() == "water") {
			rend.material = Resources.Load ("Water", typeof(Material)) as Material;
			heatElementText.text = call.getheatElement1();
			rend.sharedMaterial = rend.material;
		} else if (call.getheatElement1() == "nitrogen") {
			rend.material = Resources.Load ("seethrough", typeof(Material)) as Material;
			heatElementText.text = call.getheatElement1();
			rend.sharedMaterial = rend.material;
		}
	}


}
