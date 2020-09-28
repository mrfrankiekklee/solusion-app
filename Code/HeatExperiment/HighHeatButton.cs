using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighHeatButton : MonoBehaviour,TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	public LoadClassroom call;
	public GameObject flames;
	private Vector3 flameshigh;
	private bool isHighHeat =false;
	public LowHeatButton lowHeatButton;
	private ParticleSystem ps;
	Renderer rend;


	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		flames = GameObject.FindGameObjectWithTag ("flames");
		ps = flames.GetComponent<ParticleSystem> ();
		flameshigh = new Vector3 (1, 1, 1);
		lowHeatButton = GameObject.FindGameObjectWithTag ("minusheat").GetComponent<LowHeatButton> ();


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleTimedInput(){

		if (currentObj.tag == "plusheat") {
			StartCoroutine (LerpHigh ());
			isHighHeat = true;
			lowHeatButton.SetLowHeat (false);
			call = GameObject.Find ("GameObject").GetComponent<LoadClassroom> ();

			if (call.getheatLevel () == "high") {
				getHeatReaction getHeatR = GameObject.Find ("HeatReaction").GetComponent<getHeatReaction> ();
				getHeatR.callHeatReaction ();
			} else
				print (" It is wrong!");


		} 


	}

	IEnumerator LerpHigh(){
		float progress = 0;
		rend = flames.GetComponent<Renderer> ();
		Color myColor = new Color32(0,8,255,255);



		while(progress<= 2){
			flames.transform.localScale = Vector3.Lerp(flames.transform.localScale,flameshigh,progress);
			rend.material.SetColor ("_TintColor", myColor);
			progress+= Time.deltaTime * 0.5f;

			yield return null;

		}
		flames.transform.localScale = flameshigh;
	}

	public void setHighHeat(bool state){
		isHighHeat = state;
	}

	public bool isHighHeatOn(){

		return isHighHeat;
	}


		
}
