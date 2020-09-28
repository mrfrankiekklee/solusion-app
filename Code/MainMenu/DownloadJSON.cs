using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.IO;
using System.Text;
//using UnityEditor;

using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class DownloadJSON : MonoBehaviour {

	private InputField codeInput;
	private WWW www;
	public  string path;
	public LoadClassroom loadclassroom;
	public string jsonData="";
	// Use this for initialization
	public void OnEnable () {
			StartCoroutine (loadJSON ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator loadJSON() {

		string URL2 = "http://mrfrankiekklee.pythonanywhere.com/checkVerificationCode/";

		codeInput = GameObject.Find ("InputField").GetComponent<InputField> ();
		 www = new WWW (URL2+codeInput.text);
		yield return www;
		loadclassroom = GameObject.Find ("LoadClassroom").GetComponent<LoadClassroom> ();
		print (www.text);
		print(Application.persistentDataPath);

		File.WriteAllText (Application.persistentDataPath + "1.json", www.text);

	//	AssetDatabase.ImportAsset ("Assets/Resources/1.json", ImportAssetOptions.Default);
		loadclassroom.LoadJson ();
		moveToClassroom ();

	}
		

	public void moveToClassroom(){

		SceneManager.LoadScene ("Classroom");
	}

}
