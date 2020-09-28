using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]

public class LoadClassroom : MonoBehaviour {

	public Item item1;
	public Text monitorText;
	public  MSOptionA msOA;
	public MSOptionB msOB;
	public MSOptionC msOC;
	public MSOptionD msOD;
	public MSOptionE msOE;
	public MSOptionF msOF;
	public MSOptionG msOG;
	public GameObject heatsolution;
	public GameObject HeatSolutionSolid;
	public GameObject mixSolutionA;
	public GameObject mixSolutionASolid;
	public GameObject mixSolutionB;
	public GameObject mixSolutionBSolid;
	public Text heatElementText;
	public Text elementAText;
	public Text elementBText;
	public WWW www;
	public DownloadJSON downloadJSON;



	void Awake(){
		LoadJson ();
	
	// Use this for initialization

			
		Scene scene = SceneManager.GetActiveScene ();

		if (scene.name == "Classroom") {
			monitorText = GameObject.FindGameObjectWithTag ("monitor").GetComponent<Text> ();
			monitorText.text = getNotes ();
			heatElementText = GameObject.FindGameObjectWithTag ("heatElementText").GetComponent<Text> ();
			heatElementText.text = getheatElement1();
			elementAText = GameObject.Find ("ElementA_text").GetComponent<Text> ();
			elementAText.text = getmixElementA ();
			elementBText = GameObject.Find ("ElementB_text").GetComponent<Text> ();
			elementBText.text = getmixElementB ();
			if (getheatElementType () == "solid") {
				heatsolution.SetActive (false);
			} else {
				HeatSolutionSolid.SetActive (false);	
			}

			if(getmixElementAType() =="solid") {
				mixSolutionA.SetActive (false);

			}else {
				mixSolutionASolid.SetActive (false);	
			}
			if(getmixElementBType() =="solid") {
				mixSolutionB.SetActive (false);

			}else {
				mixSolutionBSolid.SetActive (false);	
			}





		} else if (scene.name == "MicroScope Scence") {

			msOA.getOptionAText ();
			msOB.getOptionBText ();
			msOC.getOptionCText ();
			msOC.getOptionCText ();
			msOD.getOptionDText ();
			msOE.getOptionEText ();
			msOF.getOptionFText ();
			msOG.getOptionGText ();

		}
	
	}

	[Serializable]
	public  class Item
	{ 	public string experimentNote;
		public string mixElementA;
		public string mixElementAType;
		public string mixElementB;
		public string mixElementBType;
		public string mixElementReaction;
		public string mixReverseReaction;

		public string microscope1;
		public string microscope2;
		public string microscope3;	
		public string microscope4;
		public string microscope5;
		public string microscope6;
		public string microscope7;
		public string heatElement1;
		public string heatElementType;
		public string heatLevel;
		public string heatReaction;

	}
	public  void LoadJson()

	{	
		print ("here");
		//downloadJSON = GameObject.Find ("Loadscence").GetComponent<DownloadJSON> ();
		//print ("www here:" + www.text);
		string jsonObj = File.ReadAllText(Application.persistentDataPath+"1.json");
		item1 = JsonUtility.FromJson<Item>(jsonObj);

	


	}

	public string getNotes(){
		return item1.experimentNote;
	}

	 public  string getmixElementA(){
		
		
		return item1.mixElementA;
	}
	public string getmixElementAType(){
		return item1.mixElementAType;
	}
	public string getmixElementB(){
		
		return item1.mixElementB;
	}
	public string getmixElementBType(){
		return item1.mixElementBType;
				}
	public string getMixElementReaction(){
		return item1.mixElementReaction;
	}
	public string getmixReverseReaction(){
		return item1.mixReverseReaction;
	}
	public string getmicroscope1(){
		return item1.microscope1;
	}
	public string getmicroscope2(){
		return item1.microscope2;
	}
	public string getmicroscope3(){
		return item1.microscope3;
	}
	public string getmicroscope4(){
		return item1.microscope4;
	}
	public string getmicroscope5(){
		return item1.microscope5;
	}
	public string getmicroscope6(){
		return item1.microscope6;
	}
	public string getmicroscope7(){
		return item1.microscope7;
	}
	public string getheatElement1(){
		return item1.heatElement1;
	}
	public string getheatElementType(){
		return item1.heatElementType;
	}
	public string getheatLevel(){
		return item1.heatLevel;
	}
	public string getheatReaction(){
		return item1.heatReaction;
	}
		

}