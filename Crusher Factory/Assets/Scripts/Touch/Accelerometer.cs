using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float degree = Input.acceleration.x;
		transform.Rotate (0, 0, -degree);
		Debug.Log (degree);
	}
}
