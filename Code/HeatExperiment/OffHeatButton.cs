using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffHeatButton : MonoBehaviour,TimeInputHandler{
	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject flames;
	public HighHeatButton highHeatButton;
	public LowHeatButton lowHeatButton;

	private Vector3 flamesoff;


	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		flames = GameObject.FindGameObjectWithTag ("flames");
		flamesoff = new Vector3 (0, 0, 0);
		StartCoroutine(OffBunsenBurner ());
		highHeatButton = GameObject.FindGameObjectWithTag ("plusheat").GetComponent<HighHeatButton> ();
		lowHeatButton = GameObject.FindGameObjectWithTag ("minusheat").GetComponent<LowHeatButton> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void HandleTimedInput(){
		if (currentObj.tag == "offHeat") {
			StartCoroutine (OffBunsenBurner ());
			highHeatButton.setHighHeat (false);
			lowHeatButton.SetLowHeat (false);


		}


	}

	public IEnumerator OffBunsenBurner(){
		print ("here");
		float progress = 0;

		while(progress<= 2){
			flames.transform.localScale = Vector3.Lerp(flames.transform.localScale,flamesoff,progress);
			progress+= Time.deltaTime * 0.5f;
			yield return null;

		}
		flames.transform.localScale = flamesoff;



	}
}
