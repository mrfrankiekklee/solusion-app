using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionA : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionAText;
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

	if (currentObj.tag == "micOptionA") {
		microscopeMenu.SetActive (false);
		selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
		selectOption.checkOption(call.getmicroscope1 ());
		

		} 

	}

	public void getOptionAText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionAText = this.GetComponent<Text>();
		optionAText.text = call.getmicroscope1 ();
	}

}
