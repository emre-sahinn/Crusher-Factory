using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class retry : MonoBehaviour, IPointerClickHandler {
	public GameObject menu;
	public GameObject destroyer;
	public GameObject level_end_menu;
	public GameObject level_settings;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick (PointerEventData eventData ) {
		level_settings.GetComponent<Level_settings> ().Save_User_Data ();
		menu.SetActive (true);
		level_end_menu.SetActive (false);
	}

}
