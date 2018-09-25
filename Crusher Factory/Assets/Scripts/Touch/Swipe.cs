using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {
	public GameObject character;
	public float maxTime;
	public float minSwipeDist;

	public GameObject timeObject;
	public AudioClip up_sound;
	public AudioClip down_sound;
	public AudioSource source;

	float startTime;
	float endTime;
	Vector3 StartPos;
	Vector3 EndPos;
	float SwipeDistance;
	float SwipeTime;

	public bool crusher;
	void Start () {
		
	}


	void Update () {
		if (timeObject.GetComponent<time_set>().playing_level <= 8) {
			crusher = true;
		} else {
			crusher = false;
		}

		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				startTime = Time.time;
				StartPos = touch.position;
			} else if (touch.phase == TouchPhase.Ended) {
				endTime = Time.time;
				EndPos = touch.position;

				SwipeDistance = (EndPos - StartPos).magnitude;
				SwipeTime = endTime - startTime;

				if (SwipeTime < maxTime && SwipeDistance > minSwipeDist) {
					swipe ();
				}
			}
		}	
	}


	void swipe(){
		Vector2 distance = EndPos - StartPos;
		if (Mathf.Abs (distance.x) > Mathf.Abs (distance.y)) {
			Debug.Log ("Horizontal Swipe");
			if (distance.x > 0) {
				Debug.Log ("Right Swipe");
					}else{
				Debug.Log ("Left Swipe");
			}
		} else if (Mathf.Abs (distance.x) < Mathf.Abs (distance.y)) {
			if (timeObject.GetComponent<time_set> ().start_timer == true) {
				if(crusher==true){
				Debug.Log ("Vertical Swipe");
				if (distance.y > 0) {
					Debug.Log ("Up Swipe");
					source.PlayOneShot(up_sound, 1f);
					character.GetComponent<jump>().jumpUp ();
				} else {
					Debug.Log ("Down Swipe");
					source.PlayOneShot(down_sound, 1f);
					character.GetComponent<jump>().jumpDown ();
				}
				}
			}
		}
	}
}
