using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour {

	public GameObject target;
	public float distance = 3.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(target.transform.position.x*0.8f, transform.position.y, target.transform.position.z - distance);
	}
}
