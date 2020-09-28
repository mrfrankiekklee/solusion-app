using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunsenBurnerHandle : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	private GameObject camera;
	public GameObject heatEx;
	public GameObject microscope;
	public GameObject stand;
	private Vector3 endPos;



	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		if (heatEx != null) {
			heatEx.SetActive (false);
		}
		if (this != null) {
			//turn off in the beginning	
		}
		endPos = new Vector3(-5,9,-29);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleTimedInput(){
		if (currentObj.tag == "bunsenburner") {
			heatEx.SetActive (true);
		//	StartCoroutine (moveheat ());
			stand.SetActive (false);
			microscope.SetActive (false);
			getHeatElement getHeat = GameObject.Find ("HeatElement").GetComponent<getHeatElement> ();
			getHeat.callHeat ();


		}


	}


	IEnumerator moveheat(){
		float progress = 0;

		while(progress<= 2){
			camera.transform.position = Vector3.Lerp(camera.transform.position,endPos,progress);
			progress+= Time.deltaTime * 0.5f;

			if (camera.transform.position == endPos) {
				yield break;
			}
			yield return null;

		}

	}
}
