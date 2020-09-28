using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadinator : MonoBehaviour {

	// Use this for initialization
	public void LoadNextScene(){
		SceneManager.LoadScene ("Classroom");
		
	}


	public void LoadPeriodicScene(){
		SceneManager.LoadScene ("Periodic Scence"); 
	}

}
