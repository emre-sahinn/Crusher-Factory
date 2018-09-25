using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class box_active : MonoBehaviour, IPointerClickHandler {

	public GameObject target_distance;

	public AudioSource audio;
	public AudioClip used_item_sound;

	// Update is called once per frame
	public void OnPointerClick (PointerEventData eventData ) {
		if (PlayerPrefs.GetInt ("luck_box") > 0) {
			audio.PlayOneShot(used_item_sound, 0.7f);
			GameObject explosion = (GameObject)Instantiate (Resources.Load ("Explosion"), transform.position, transform.rotation);
			Destroy (explosion, 1);
			Instantiate (Resources.Load ("luck_box"), target_distance.transform.position, transform.rotation);
			PlayerPrefs.SetInt ("luck_box", PlayerPrefs.GetInt ("luck_box") - 1);
			PlayerPrefs.Save ();
		}
	}
}
