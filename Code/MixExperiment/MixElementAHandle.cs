using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixElementAHandle : MonoBehaviour, TimeInputHandler {
	public GameObject currentObj;
	public GameObject gameViewer;
	private addTestTubeAColor addAColor;
	public Animation animationA;
	private TestTubeA testTubeA;
	private bool isElementAadded =false;
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

		if (currentObj.name == "ElementA_text") {
			if (call.getmixElementAType() == "liquid") {
				addAColor = GameObject.Find ("test-tube_solutionA").GetComponent<addTestTubeAColor> ();
				if (isElementAadded == false) {
					addAColor.addColortoMix ();
					isElementAadded = true;
				}
			}
			animationA = GameObject.Find ("Test-tube-A").GetComponent<Animation> ();
			animationA.Play ();			 
			mixCheckOrder.setElement (call.getmixElementA ());

			testTubeA = GameObject.Find ("ElementA_text").GetComponent<TestTubeA> ();

			testTubeA.setElementA(true);

	
	
	}
}


	private IEnumerator WaitForAnimation ( Animation animation )
	{
		do
		{
			yield return null;
		} while ( animation.isPlaying );
	} 
}
