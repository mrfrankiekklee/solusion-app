using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOption : MonoBehaviour {
	public GameObject NH3;
	public GameObject O2;
	public GameObject CH4;
	public GameObject monitor;
	public Material []array_material;
	Renderer rend;


	void Start(){
		
		NH3.SetActive (false);
		O2.SetActive (false);
		CH4.SetActive (false);
		monitor = GameObject.Find ("Monitor");
		monitor.SetActive (false);
		rend = monitor.GetComponent<Renderer> ();
		rend.enabled = true;



	}

	// Use this for initialization
	public void checkOption (string option) {
		
		if (option == "NH3") {

			NH3.SetActive (true);
			monitor.SetActive (true);
			rend.sharedMaterial = array_material [0];

		
		
		} else if (option == "O2") {

			O2.SetActive (true);
			monitor.SetActive (true);
			rend.sharedMaterial = array_material [1];



		} else if (option == "CH4") {

			CH4.SetActive (true);
			monitor.SetActive (true);
			rend.sharedMaterial = array_material [2];

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
