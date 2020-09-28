using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionG : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionGText;
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

		if (currentObj.tag == "micOptionG") {
			microscopeMenu.SetActive (false);
			selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
			selectOption.checkOption(call.getmicroscope7 ());

		} 

	}

	public void getOptionGText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionGText = this.GetComponent<Text>();
		optionGText.text = call.getmicroscope7 ();
	}

}
