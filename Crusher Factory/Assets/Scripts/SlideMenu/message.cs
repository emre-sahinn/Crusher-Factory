using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class message : MonoBehaviour {
	public string messageText;
	public GameObject my_text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		my_text.GetComponent<Text> ().text = messageText;
	}

	public void start_command(){
		StartCoroutine (start());
	}

	IEnumerator start(){
		yield return new WaitForSeconds (5);
		this.gameObject.SetActive (false);
	}
		
}
