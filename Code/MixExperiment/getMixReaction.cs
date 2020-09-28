using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getMixReaction : MonoBehaviour {
	public LoadClassroom call;
	public GameObject mixReaction;
	Renderer rend;
	public CheckOrder checkOrder;
	private string[] elementOrder;


	void Start(){

	
	}

	// Use this for initialization
	public void callMixReaction () {
		//call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		//heatReaction =GameObject.FindGameObjectWithTag("heatReaction");
		print ("Mix Reaction is : " + call.getMixElementReaction());

		handleMixReaction();





	}

	// Update is called once per frame
	void Update () {
		checkOrder = GameObject.Find ("Mixsolution").GetComponent<CheckOrder> ();
		call = GameObject.Find("GameObject").GetComponent<LoadClassroom>();
		elementOrder =checkOrder.getMixOrder ();
		if (elementOrder [0] == call.getmixElementA () && elementOrder [1] == call.getmixElementB ()) {
			handleMixReaction ();
			checkOrder.setEmpty ();

		} else if (elementOrder [0] == call.getmixElementB () && elementOrder [1] == call.getmixElementA ()) {
			handleMixReverseReaction ();
			checkOrder.setEmpty ();
		
		}

	}

	void handleMixReaction(){
		if (call.getMixElementReaction() == "smoke") {
			mixReaction = Instantiate(Resources.Load("SmokeEffect") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 

		else if (call.getMixElementReaction() == "white explosion") {
			mixReaction = Instantiate(Resources.Load("WhiteExplosion") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 

		else if (call.getMixElementReaction() == "sparks") {
			mixReaction = Instantiate(Resources.Load("Flare") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 
	}

	void handleMixReverseReaction(){
		if (call.getmixReverseReaction() == "smoke") {
			mixReaction = Instantiate(Resources.Load("SmokeEffect") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 

		else if (call.getmixReverseReaction() == "white explosion") {
			mixReaction = Instantiate(Resources.Load("WhiteExplosion") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 

		else if (call.getmixReverseReaction() == "sparks") {
			mixReaction = Instantiate(Resources.Load("Flare") as GameObject, new Vector3(1f,6f,-20f),transform.rotation);


		} 
	}


}
