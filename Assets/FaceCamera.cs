using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour {

	private CameraTarget cameraTarget;
	private Transform targetTransform;
	// Use this for initialization
	void Start () {
		cameraTarget = FindObjectOfType<CameraTarget> ();
		targetTransform = cameraTarget.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetTransform != null) {
			transform.LookAt(targetTransform);
		}
	}
}
