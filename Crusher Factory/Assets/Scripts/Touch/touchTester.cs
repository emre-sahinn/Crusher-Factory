using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTester : MonoBehaviour {

	void Start () {
		
	}

	Ray ray;
	RaycastHit hit;
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			Debug.DrawRay (ray.origin,ray.direction*20,Color.red);
			if (Physics.Raycast (ray,out hit,Mathf.Infinity)) {//out yazarak bütün ray infosunu alıyoruz
				Debug.Log ("bi şeye çarptık"+hit.transform.name);
				Destroy (hit.transform.gameObject);
			}
		}
	}
}
