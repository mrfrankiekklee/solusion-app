using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSOptionD : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject microscopeMenu;
	public LoadClassroom call;
	private Text optionDText;
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

		if (currentObj.tag == "micOptionD") {
			microscopeMenu.SetActive (false);
			selectOption = GameObject.Find ("OptionHandler").GetComponent<SelectOption>(); 
			selectOption.checkOption(call.getmicroscope4 ());

		} 

	}

	public void getOptionDText(){
		call = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		optionDText = this.GetComponent<Text>();
		optionDText.text = call.getmicroscope4 ();
	}

}
