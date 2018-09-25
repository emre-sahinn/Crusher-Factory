using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text_amount : MonoBehaviour {

	public GameObject hp_potion;
	public GameObject time_potion;
	public GameObject luck_box;
	
	// Update is called once per frame
	void Update () {
		hp_potion.GetComponent<Text> ().text = PlayerPrefs.GetInt ("health_potion").ToString ();
		time_potion.GetComponent<Text> ().text = PlayerPrefs.GetInt ("time_potion").ToString ();
		luck_box.GetComponent<Text> ().text = PlayerPrefs.GetInt ("luck_box").ToString ();
	}
}
