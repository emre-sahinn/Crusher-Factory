using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class set_price : MonoBehaviour, IPointerClickHandler {
	public GameObject item;
	public int price;
	public bool gem;
	public GameObject buy_button;

	public void OnPointerClick (PointerEventData eventData) {
		buy_button.GetComponent<quantity> ().gem = gem;
		buy_button.GetComponent<quantity> ().price = price;
		buy_button.GetComponent<quantity> ().bought_item = item;
	}
}
