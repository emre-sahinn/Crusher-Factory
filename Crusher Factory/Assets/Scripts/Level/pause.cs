using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pause : MonoBehaviour, IPointerClickHandler {
	public int setZero;
	public bool isButton=false;
	public GameObject timeObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isButton == false) {
			timeObject.GetComponent<time_set> ().start_timer = false;
		}else timeObject.GetComponent<time_set> ().start_timer = true;
	}

	public void OnPointerClick (PointerEventData eventData ) {
		

		if (setZero == 1) {
			
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}
}
