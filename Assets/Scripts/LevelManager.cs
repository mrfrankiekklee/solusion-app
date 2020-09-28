using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadNextScene(){
		print ("here");
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void Quit(){
		print ("Game will Quit");
		Application.Quit ();

	}
}
