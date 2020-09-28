using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionE : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionEText;
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

		if (currentObj.tag == "micOptionE") {
			microscopeMenu.SetActive (false);
			selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
			selectOption.checkOption(call.getmicroscope5 ());

		} 

	}

	public void getOptionEText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionEText = this.GetComponent<Text>();
		optionEText.text = call.getmicroscope5 ();
	}

}
