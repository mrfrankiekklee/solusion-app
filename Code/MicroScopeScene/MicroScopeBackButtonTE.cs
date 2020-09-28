using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroScopeBackButtonTE : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public GameObject NH3;
	public GameObject O2;
	public GameObject monitor;

	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		
	}
	
	// Update is called once per frame

		
	public void HandleTimedInput(){

			if (currentObj.tag == "micBackbutton")
				microscopeMenu.SetActive (true);
				NH3.SetActive (false);
				O2.SetActive (false);
				monitor.SetActive (false);

		}


}
