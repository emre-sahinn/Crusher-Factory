using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Save : MonoBehaviour {

	public GameObject score;


	public void SaveData () {
		PlayerPrefs.SetString("Score", score.GetComponent<Text>().text);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerPrefs.GetString("Score", "0"));
	}
}