using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language : MonoBehaviour {
	public bool tr;

	public void setLanguage () {
		if (tr == true) {
			PlayerPrefs.SetInt ("tr", 1);
		} else {
			PlayerPrefs.SetInt ("tr", 0);
		}
	}
}
