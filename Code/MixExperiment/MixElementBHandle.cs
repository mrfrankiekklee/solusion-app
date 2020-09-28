using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixElementBHandle : MonoBehaviour, TimeInputHandler {

	public GameObject currentObj;
	public GameObject gameViewer;
	private addTestTubeBColor addBColor;
	public Animation animationB;
	private TestTubeB testTubeB;
	private bool isElementBadded = false;
	public LoadClassroom call;


	private CheckOrder mixCheckOrder;



	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		mixCheckOrder = GameObject.Find ("Mixsolution").GetComponent<CheckOrder> ();
		call = GameObject.Find ("GameObject").GetComponent<LoadClassroom> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void HandleTimedInput(){
		if(currentObj.name =="ElementB_text"){
			if (call.getmixElementBType () == "liquid") {
				
				addBColor = GameObject.Find ("test-tube_solutionB").GetComponent<addTestTubeBColor> ();
				print ("hereeeeeee");
				if (isElementBadded == false) {
					addBColor.addColortoMix ();
					isElementBadded = true;
				}

			}
			animationB = GameObject.Find ("Test-tube-B").GetComponent<Animation> ();
			animationB.Play ();



				// return new WaitForSeconds(2);
				StartCoroutine (WaitForAnimation ());
				mixCheckOrder.setElement (call.getmixElementB ());

				testTubeB = GameObject.Find ("ElementB_text").GetComponent<TestTubeB> ();

				testTubeB.setElementB (true);

	
	}
}

	private IEnumerator WaitForAnimation ( )
	{
		print ("waiting");
		yield return new WaitForSeconds(2);
	

}
}
