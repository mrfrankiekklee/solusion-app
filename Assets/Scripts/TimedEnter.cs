using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedEnter : MonoBehaviour ,TimeInputHandler {

	public GameObject currentObj;
	public GameObject gameViewer;

	//Classroom variables 

	public GameObject heatEx;
	public GameObject mixEx;
	public GameObject stand;
	public GameObject microscope;
	public GameObject bunsenburner;
	private CameraZoomIn camera;
	private bool moving = false;
	private bool heatMove = false;
	private bool heatMoveBack = false;
	private bool flameslevel = false;
	private bool heatExActive =false;
	public GameObject flames;
	private Quaternion  endRo= Quaternion.identity;
	private Vector3 endPos;
	private Vector3 originalPos;
	private float lerpTime=5;
	private float currentLerpTime =0;
	private Vector3 flameshigh;
	private Vector3 flamesoff;

	//Microscope variables 
	public GameObject microscopeMenu;


	void Start() {
		currentObj = gameObject;
		gameViewer = currentObj.transform.GetChild (0).gameObject;
		camera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CameraZoomIn> ();
		flames = GameObject.FindGameObjectWithTag ("flames");
		if (bunsenburner != null) {
			StartCoroutine (LerpDown ());
		}
		if (heatEx != null) {
			heatEx.SetActive (false);
		}
		if (mixEx != null) {
			mixEx.SetActive (false);
		}


		flameshigh = new Vector3 (1, 1, 1);
		flamesoff = new Vector3 (0, 0, 0);
		endPos = new Vector3(-5,9,-29);
		originalPos = new Vector3 (0, 9, -29);
	}

	void Update() {

		if (moving == true && Vector3.Distance (currentObj.transform.position, camera.cameraPos) > 5) { // and sitance == to smt
			camera.MoveToTarget (gameViewer);

		}
	
	}
	// Use this for initialization
	public void HandleTimedInput(){
		

		//All Classroom Tags 
		if (currentObj.tag == "microscope") {
			moving = true;
			StartCoroutine (movesceneMS ());


		} else if (currentObj.tag == "periodic_table") {
			moving = true;
			StartCoroutine (movescenePT ());

		} else if (currentObj.tag == "tripod") {
			moving = true;
		} else if (currentObj.tag == "door") {
			moving = true;
			StartCoroutine (movesceneDoor ());
		} else if (currentObj.tag == "plusheat") {
			StartCoroutine (LerpUP ());

		} else if (currentObj.tag == "minusheat") {
			StartCoroutine (LerpDown ());
		} else if (currentObj.tag == "mixBackbutton") {
			mixEx.SetActive (false);
			bunsenburner.SetActive (true);
			microscope.SetActive (true);
			stand.SetActive (true);

		} else if (currentObj.tag == "heatBackButton") {
			StartCoroutine (movefromheat ());
			heatEx.SetActive (false);
			stand.SetActive (true);
			microscope.SetActive (true);

		} else if (currentObj.tag == "bunsenburner") {
			heatEx.SetActive (true);
			StartCoroutine (moveheat ());
			stand.SetActive (false);
			microscope.SetActive (false);
			getHeatElement getHeat = GameObject.Find ("HeatElement").GetComponent<getHeatElement> ();
			getHeatReaction getHeatR = GameObject.Find ("HeatReaction").GetComponent<getHeatReaction> ();
			getHeat.callHeat ();
			getHeatR.callHeatReaction ();


		} else if (currentObj.tag == "testtubestand") {
			mixEx.SetActive (true);
			microscope.SetActive (false);
			bunsenburner.SetActive (false);
			stand.SetActive (false);
			getElementA getA = GameObject.Find ("Element A").GetComponent<getElementA> ();
			getElementB getB = GameObject.Find ("Element B").GetComponent<getElementB> ();

			getA.callA ();
			getB.callB ();
		} //All Microscope scene----------------------------->
		else if (currentObj.tag == "homepagebutton") {
			StartCoroutine (movesClassroom ());
			
		} else if (currentObj.tag == "micOptionA") {
			microscopeMenu.SetActive (false);
		
		
		} else if (currentObj.tag == "micBackbutton")
			microscopeMenu.SetActive (true);

		}



	IEnumerator movescenePT(){
		yield return new WaitForSecondsRealtime (1);
		SceneManager.LoadScene ("Periodic Scence"); 
	}

	IEnumerator movesceneMS(){
		yield return new WaitForSecondsRealtime (1);
		SceneManager.LoadScene ("MicroScope Scence"); 
	}

	IEnumerator movesceneDoor(){
		yield return new WaitForSecondsRealtime (1);
		SceneManager.LoadScene ("Menu 3D"); 
	}

	IEnumerator movesClassroom(){
		yield return new WaitForSecondsRealtime (1);
		SceneManager.LoadScene ("Classroom");
	}
	IEnumerator moveheat(){
		float progress = 0;

		while(progress<= 2){
			camera.transform.position = Vector3.Lerp(camera.transform.position,endPos,progress);
			print (camera.transform.position);
			progress+= Time.deltaTime * 0.5f;

			if (camera.transform.position == endPos) {
				yield break;
			}
			yield return null;

		}

	}

	IEnumerator movefromheat(){

			camera.transform.position = Vector3.Lerp(camera.transform.position,originalPos,0.7f);


		//camera.transform.Translate (originalPos * Time.deltaTime);
		yield return null;

	}




	IEnumerator LerpUP(){
		float progress = 0;


		while(progress<= 2){
			flames.transform.localScale = Vector3.Lerp(flames.transform.localScale,flameshigh,progress);
			progress+= Time.deltaTime * 0.01f;

			yield return null;

	}
		flames.transform.localScale = flameshigh;
}  
	IEnumerator LerpDown(){
		float progress = 0;


		while(progress<= 2){
			flames.transform.localScale = Vector3.Lerp(flames.transform.localScale,flamesoff,progress);
			progress+= Time.deltaTime * 0.5f;
			yield return null;

		}
		flames.transform.localScale = flamesoff;
	}
}
