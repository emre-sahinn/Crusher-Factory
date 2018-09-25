using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class quantity : MonoBehaviour, IPointerClickHandler {
	public GameObject quantity_text;
	public GameObject scroll_bar;
	public int price;
	public int price2;
	public int price_stage;
	public bool gem;
	public GameObject gold_image;
	public GameObject gem_image;
	public GameObject price_text;
	public GameObject event_settings;
	public GameObject congrats;
	public GameObject quantity_panel;
	public GameObject insufficient_panel;

	public GameObject number_of_item_text;
	public GameObject bought_item;

	public GameObject hp_pot;
	public GameObject time_pot;
	public GameObject luck_box;

	public void OnPointerClick (PointerEventData eventData) {
		number_of_item_text.GetComponent<Text> ().text = price_stage.ToString();
		if (price_stage == 0) {
			quantity_panel.SetActive (false);
		}else if (gem == false && PlayerPrefs.GetInt("gold") >= price2) {
			PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold") - price2);
			if (bought_item.name == "health_potion") {
				event_settings.GetComponent<Level_settings> ().hp_potion += price_stage;
				PlayerPrefs.SetInt (bought_item.name, event_settings.GetComponent<Level_settings>().hp_potion);
				PlayerPrefs.Save ();
				hp_pot.SetActive (true);
				time_pot.SetActive (false);
				luck_box.SetActive (false);
			}
			congrats.SetActive (true);
			quantity_panel.SetActive (false);
		} else if (gem == true && PlayerPrefs.GetInt("gem") >= price2) {
			PlayerPrefs.SetInt ("gem", PlayerPrefs.GetInt ("gem") - price2);
			if (bought_item.name == "time_potion") {
				event_settings.GetComponent<Level_settings> ().time_potion += price_stage;
				PlayerPrefs.SetInt (bought_item.name, event_settings.GetComponent<Level_settings> ().time_potion);
				PlayerPrefs.Save ();
				time_pot.SetActive (true);
				hp_pot.SetActive (false);
				luck_box.SetActive (false);
			} else if (bought_item.name == "luck_box") {
				event_settings.GetComponent<Level_settings> ().luck_box += price_stage;
				PlayerPrefs.SetInt (bought_item.name, event_settings.GetComponent<Level_settings> ().luck_box);
				PlayerPrefs.Save ();
				luck_box.SetActive (true);
				hp_pot.SetActive (false);
				time_pot.SetActive (false);
			}
			bought_item.SetActive (true);
			congrats.SetActive (true);
			PlayerPrefs.Save ();
			quantity_panel.SetActive (false);
		} else {
			insufficient_panel.SetActive (true);
		}

	}

	// Update is called once per frame
	void Update () {
		
		price_text.GetComponent<Text> ().text = price2.ToString ();
		if (gem == true) {
			gem_image.SetActive (true);
			gold_image.SetActive (false);
		} else {
			gem_image.SetActive (false);
			gold_image.SetActive (true);
		}

		float scroll_value = scroll_bar.GetComponent<Scrollbar> ().value;
		price2 = price*price_stage;
		if (scroll_value < 0.06f) {
			price_stage = 0;
			quantity_text.GetComponent<Text> ().text = "0";
		}else if (scroll_value < 0.17f && scroll_value > 0.06f) {
			price_stage = 1;
			quantity_text.GetComponent<Text> ().text = "1";
		}else if (scroll_value < 0.27f && scroll_value > 0.17f) {
			price_stage = 2;
			quantity_text.GetComponent<Text> ().text = "2";
		}else if (scroll_value < 0.38f && scroll_value > 0.27f) {
			price_stage = 3;
			quantity_text.GetComponent<Text> ().text = "3";
		}else if (scroll_value < 0.49f && scroll_value > 0.38f) {
			price_stage = 4;
			quantity_text.GetComponent<Text> ().text = "4";
		}else if (scroll_value < 0.60 && scroll_value > 0.49f) {
			price_stage = 5;
			quantity_text.GetComponent<Text> ().text = "5";
		}else if (scroll_value < 0.71f && scroll_value > 0.60) {
			price_stage = 6;
			quantity_text.GetComponent<Text> ().text = "6";
		}else if (scroll_value < 0.82 && scroll_value > 0.71) {
			price_stage = 7;
			quantity_text.GetComponent<Text> ().text = "7";
		}else if (scroll_value < 0.94 && scroll_value > 0.82) {
			price_stage = 8;
			quantity_text.GetComponent<Text> ().text = "8";
		}else if (scroll_value <= 1.0f && scroll_value > 0.94) {
			price_stage = 9;
			quantity_text.GetComponent<Text> ().text = "9";
		}

	}
}
