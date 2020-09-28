using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorHandle : MonoBehaviour, TimeInputHandler{
	public GameObject currentObj;
	public GameObject gameViewer;
	private CameraZoomIn camera;
	private bool moving = false;


	// Use this for initialization
	void Start () {
		currentObj = gameObject;
		gameViewer = currentObj.transform.gameObject;
		camera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CameraZoomIn> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (moving == true && Vector3.Distance (currentObj.transform.position, camera.cameraPos) > 5) { // and sitance == to smt
			camera.MoveToTarget (gameViewer);
		}
	}


	public void HandleTimedInput(){

			if (currentObj.tag == "door") {
			moving = true;
			StartCoroutine (movesceneDoor ());
		} 
}
	IEnumerator movesceneDoor(){
		yield return new WaitForSecondsRealtime (1);
		SceneManager.LoadScene ("Menu 3D"); 
	}

}
