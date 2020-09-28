using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMolecule : MonoBehaviour {
	float rotPerMinute = 6.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(6.0f * rotPerMinute * Time.deltaTime, 0, 0);
	}
}
