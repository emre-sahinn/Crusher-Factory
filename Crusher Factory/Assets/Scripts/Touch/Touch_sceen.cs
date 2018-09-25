using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_sceen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("Başladı");
			}
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				Debug.Log ("Hareketli");
			}
			if (Input.GetTouch (0).phase == TouchPhase.Ended) {
				Debug.Log ("Bitti");
			}

		}


	}
}
