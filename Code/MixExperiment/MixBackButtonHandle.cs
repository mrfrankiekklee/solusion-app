using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixBackButtonHandle : MonoBehaviour,TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject mixEx;
	public GameObject stand;
	public GameObject microscope;
	public GameObject bunsenburner;
	private bool isTestTubesActive = false;



	// Use this for initialization
	void Start () {

		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void HandleTimedInput(){

		if (currentObj.tag == "mixBackbutton") {
			mixEx.SetActive (false);
			bunsenburner.SetActive (true);
			microscope.SetActive (true);
			stand.SetActive (true);

			isTestTubesActive = false;

		}




	}
}
