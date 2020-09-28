using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
[System.Serializable]

public class LoadClassroom : MonoBehaviour {

	public Item item1;
	public Text monitorText;
	// Use this for initialization
	void Start () {
			
		LoadJson ();
		monitorText = GameObject.FindGameObjectWithTag ("monitor").GetComponent<Text>();
		monitorText.text = getNotes ();

	
	}

	[Serializable]
	public  class Item
	{ 	public string experimentNote;
		public string mixElementA;
		public string mixElementB;
		public string mixElementReaction;
		public string mixElementA0;
		public string mixElementB0;
		public string mixElementReaction0;
		public string mixElementA1;
		public string mixElementB1;
		public string mixElementReaction1;
		public string microscope1;
		public string microscope2;
		public string microscope3;	
		public string microscope4;
		public string microscope5;
		public string microscope6;
		public string microscope7;
		public string heatElement1;
		public string heatLevel;
		public string heatReaction;

	}
	public  void LoadJson()

	{	
		TextAsset jsonObj = Resources.Load("1") as TextAsset;
			item1 = JsonUtility.FromJson<Item>(jsonObj.text);
			print(item1.mixElementA);
			print(item1.mixElementB);
			print(item1.mixElementReaction);


	}

	public string getNotes(){
		return item1.experimentNote;
	}

	 public  string getmixElementA(){
		
		
		return item1.mixElementA;
	}
	public string getmixElementB(){
		
		return item1.mixElementB;
	}
	public string getmixElementReaction(){
		return item1.mixElementReaction;
	}
	public string getmixElementA0(){
		return item1.mixElementA0;
	}
	public string getmixElementB0(){
		return item1.mixElementB0;
	}
	public string getmixElementReaction0(){
		return item1.mixElementReaction0;
	}
	public string getmixElementA1(){
		return item1.mixElementA1;
	}
	public string getmixElementB1(){
		return item1.mixElementB1;
	}
	public string getmixElementReaction1(){
		return item1.mixElementReaction1;
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
	public string getheatLevel(){
		return item1.heatLevel;
	}
	public string getheatReaction(){
		return item1.heatReaction;
	}
		

}