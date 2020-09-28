using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatBackButton : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject heatEx;
	public GameObject stand;
	public GameObject microscope;
	private Vector3 originalPos;
	private GameObject camera;
	public HighHeatButton highHeatButton;
	public LowHeatButton lowHeatButton;




	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		originalPos = new Vector3 (0, 9, -29);
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		highHeatButton = GameObject.FindGameObjectWithTag ("plusheat").GetComponent<HighHeatButton> ();
		lowHeatButton = GameObject.FindGameObjectWithTag ("minusheat").GetComponent<LowHeatButton> ();



		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleTimedInput(){


		if (currentObj.tag == "heatBackButton") {

			if (highHeatButton.isHighHeatOn () == true || lowHeatButton.isLowHeatOn () == true) {

				print ("turn off the microscope");
			}
			else {

			StartCoroutine (movefromheat ());
			heatEx.SetActive (false);
			microscope.SetActive (true);
				stand.SetActive (true);
			}


		}
	
	
	
	
	}

	IEnumerator movefromheat(){
		float progress = 0;


		while (progress <= 2) {

			camera.transform.position = Vector3.Lerp (camera.transform.position, originalPos, 0.7f);
			progress += Time.deltaTime * 0.5f;


			if (camera.transform.position == originalPos) {
				yield break;
			}
			//camera.transform.Translate (originalPos * Time.deltaTime);
			yield return null;
		}

	}
}
