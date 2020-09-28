﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MicroScopeHomeTE : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;


	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;

	}

	// Update is called once per frame


	public void HandleTimedInput(){

		if (currentObj.tag == "homepagebutton") {
			 movesClassroom ();

		} 

	}

	private void movesClassroom(){

		SceneManager.LoadScene ("Classroom");
	}
}