using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class shop : MonoBehaviour, IPointerClickHandler {
	public GameObject shop_menu;
	public GameObject menu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnPointerClick (PointerEventData eventData ) {
		shop_menu.SetActive (true);
		menu.SetActive (false);
	}
}
