﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionC : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionCText;
	private SelectOption selectOption;
	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;

	}

	// Update is called once per frame
	void Update () {
	}

	public void HandleTimedInput(){

		if (currentObj.tag == "micOptionC") {
			microscopeMenu.SetActive (false);
			selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
			selectOption.checkOption(call.getmicroscope3 ());


		} 

	}

	public void getOptionCText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionCText = this.GetComponent<Text>();
		optionCText.text = call.getmicroscope3 ();
	}

}
