using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getHeatLevel : MonoBehaviour {

	public LoadClassroom call;
	Renderer rend;


	// Use this for initialization
	public void getHeat() {

		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		print ("Heat Level is:" + call.getheatLevel());

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
