using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_empty : MonoBehaviour {

	public GameObject hp_potion;
	public GameObject time_potion;
	public GameObject luck_box;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("health_potion") > 0) {
			hp_potion.SetActive (true);
		} else {
			hp_potion.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("time_potion") > 0) {
			time_potion.SetActive (true);
		} else {
			time_potion.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("luck_box") > 0) {
			luck_box.SetActive (true);
		} else {
			luck_box.SetActive (false);
		}



	}
}
