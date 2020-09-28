using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOrder : MonoBehaviour {
	private string[] mixOrder = new string[2];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < mixOrder.Length; i++) {
			mixOrder [i] = "_";

		}
		
	}
	
	// Update is called once per frame
	void Update () {

	

	}


	public void setElement(string element){

		for (int i = 0; i < mixOrder.Length; i++) {
			if (mixOrder [i] == "_") {
				mixOrder [i] = element;
				print ("Array: " +mixOrder [i]);

				break;

			}

		}

	}
	public void setEmpty(){
		for (int i = 0; i < mixOrder.Length; i++) {
			mixOrder [i] = "_";

		}


	}

	public string[] getMixOrder(){
		return mixOrder;
	}
}
