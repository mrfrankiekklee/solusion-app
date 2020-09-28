using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowHeatButton : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	private Vector3 flameslow;
	public GameObject flames;
	private bool isLowHeat;
	public LoadClassroom call;
	public HighHeatButton highHeatButton;
	Renderer rend;


	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		flames = GameObject.FindGameObjectWithTag ("flames");
		flameslow = new Vector3 (1, 1, 1);
		highHeatButton = GameObject.FindGameObjectWithTag ("plusheat").GetComponent<HighHeatButton> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void HandleTimedInput(){

		if (currentObj.tag == "minusheat") {
			StartCoroutine (LerpLow ());
			isLowHeat = true;
			highHeatButton.setHighHeat (false);
			call = GameObject.Find ("GameObject").GetComponent<LoadClassroom> ();
			if (call.getheatLevel () == "low") {
				getHeatReaction getHeatR = GameObject.Find ("HeatReaction").GetComponent<getHeatReaction> ();
				getHeatR.callHeatReaction ();
			} else {
				print (" It is wrong!");
			}
		} 

	}

	IEnumerator LerpLow(){
		float progress = 0;
		rend = flames.GetComponent<Renderer> ();
		Color myColor = new Color32(255,255,0,255);


		while(progress<= 2){
			flames.transform.localScale = Vector3.Lerp(flames.transform.localScale,flameslow,progress);
			rend.material.SetColor ("_TintColor", myColor);
			progress+= Time.deltaTime * 0.5f;
			yield return null;

		}
		flames.transform.localScale = flameslow;
	}

	public void SetLowHeat(bool state) {
		isLowHeat = state;
	}

	public bool isLowHeatOn(){
		return isLowHeat;
	
	}
}
