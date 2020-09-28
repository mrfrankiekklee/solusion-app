using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomIn : MonoBehaviour {

	public float moveSpeed = 35.0f;
	public Vector3 cameraPos;

	void Start() {

		cameraPos = gameObject.transform.position;
	}
	public void MoveToTarget(GameObject targetobj){
		transform.position = Vector3.MoveTowards(transform.position, targetobj.transform.position, moveSpeed * Time.deltaTime);
		cameraPos = gameObject.transform.position;
	}

}
