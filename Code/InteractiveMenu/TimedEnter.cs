using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedEnter : MonoBehaviour ,TimeInputHandler {

	public GameObject currentObj;
	public GameObject gameViewer;
	private GameObject camera;
	public LoadClassroom call;

	//Classroom variables 

	public GameObject heatEx;
	public GameObject mixEx;
	public GameObject stand;
	public GameObject microscope;
	public GameObject bunsenburner;


	//mix experiment
	public Animation animationA;
	public Animation animationB;
	private int countAdd=0;

	private TestTubeA testTubeA;
	private TestTubeB testTubeB;
	private addTestTubeAColor addAColor;
	private addTestTubeBColor addBColor;

	private bool isTestTubesActive = false;
	private bool isElementAadded =false;
	private bool isElementBadded = false;


	void Awake(){

	}


	void Start() {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		camera = GameObject.FindGameObjectWithTag ("MainCamera");

		if (isTestTubesActive == true) {
			testTubeA = GameObject.Find ("ElementA_text").GetComponent<TestTubeA> ();
		
			testTubeB = GameObject.Find ("ElementB_text").GetComponent<TestTubeB> ();
		}

		if (mixEx != null) {
			mixEx.SetActive (false);
		}

	}
	void Update(){
	/*	if(isTestTubesActive==true){
		if (testTubeA.isElementAActive() == true) {
			countAdd = 1;

			if (testTubeB.isElementBActive()==true &&countAdd==1 ) {
				getMixReaction getMixR = GameObject.Find ("MixReaction").GetComponent<getMixReaction> ();
				getMixR.callMixReaction ();
				testTubeA.setElementA(false);
				testTubeB.setElementB (false);
			}
		} else if (testTubeB.isElementBActive() == true) {
			countAdd =2;
			if(testTubeA.isElementAActive() ==true && countAdd ==2){
				getMixReaction getMixR = GameObject.Find ("MixReaction").GetComponent<getMixReaction> ();
				getMixR.callMixReaction ();
				testTubeA.setElementA(false);
				testTubeB.setElementB (false);
			}
		}
	}*/
	}

	// Use this for initialization
	public void HandleTimedInput(){



		//Heat Experiment
		if (currentObj.tag == "testtubestand") {
			mixEx.SetActive (true);
			microscope.SetActive (false);
			bunsenburner.SetActive (false);
			stand.SetActive (false);
			getElementA getA = GameObject.Find ("ElementA").GetComponent<getElementA> ();
			getElementB getB = GameObject.Find ("ElementB").GetComponent<getElementB> ();

			getA.callA ();
			getB.callB ();
			enableC ();
			isTestTubesActive = true;

		} 
	}


	public void enableC() {
		
			testTubeA = GameObject.Find ("ElementA_text").GetComponent<TestTubeA> ();
		print ("im here" + testTubeA.isElementAActive());
			testTubeB = GameObject.Find ("ElementB_text").GetComponent<TestTubeB> ();
		isTestTubesActive = true;
	}
}
