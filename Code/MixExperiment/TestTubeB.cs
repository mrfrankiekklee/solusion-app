using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeB : MonoBehaviour {

	private bool elementB = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public bool isElementBActive() {
		return elementB;

	}

	public void setElementB(bool state) {
		elementB = state;
	}
}
