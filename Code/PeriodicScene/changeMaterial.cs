using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour,TimeInputHandler{

	public GameObject currentObj;
	public GameObject gameViewer;
	public GameObject monitor;

	public Material material; 
	Renderer rend;

	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;

	
		rend = monitor.GetComponent<Renderer> ();
		rend.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void HandleTimedInput(){


		rend.sharedMaterial = material;
	
	
	
	}
}
