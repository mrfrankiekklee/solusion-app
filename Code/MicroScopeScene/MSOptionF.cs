using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionF : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionFText;
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

		if (currentObj.tag == "micOptionF") {
			microscopeMenu.SetActive (false);
			selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
			selectOption.checkOption(call.getmicroscope6 ());

		} 

	}

	public void getOptionFText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionFText = this.GetComponent<Text>();
		optionFText.text = call.getmicroscope6 ();
	}

}
