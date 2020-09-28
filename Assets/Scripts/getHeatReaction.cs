using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getHeatReaction : MonoBehaviour {
	public LoadClassroom call;
	public GameObject heatReaction;
	public Vector3 reactionPos;
	Renderer rend;


	// Use this for initialization
	public void callHeatReaction () {
		//	LoadClassroom.getmixElementB ();

		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		//heatReaction =GameObject.FindGameObjectWithTag("heatReaction");
		print ("Heat Reaction is : " + call.getheatReaction());

		handleHeatReaction();





	}

	// Update is called once per frame
	void Update () {


	}

	void handleHeatReaction(){
		if (call.getheatReaction() == "smoke") {
			//heatReaction = Instantiate(Resources.Load("SmokeEffect") as GameObject, new Vector3(-6f,9f,-23f),transform.rotation);
			Instantiate(heatReaction, new Vector3(-6f,9f,-23f),transform.rotation);


		} 
	}


}
