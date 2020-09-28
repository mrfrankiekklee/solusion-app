using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeStandHandle : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject mixEx;
	public GameObject stand;
	public GameObject microscope;
	public GameObject bunsenburner;

	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		if (mixEx != null) {
			mixEx.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleTimedInput(){
		if (currentObj.tag == "testtubestand") {
			mixEx.SetActive (true);
			microscope.SetActive (false);
			bunsenburner.SetActive (false);
			stand.SetActive (false);
			getElementA getA = GameObject.Find ("ElementA").GetComponent<getElementA> ();
			getElementB getB = GameObject.Find ("ElementB").GetComponent<getElementB> ();

			getA.callA ();
			getB.callB ();
		//	enableC ();
		//	isTestTubesActive = true;

		} 
	
	}
}
