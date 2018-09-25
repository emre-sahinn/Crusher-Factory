using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class hp_active : MonoBehaviour, IPointerClickHandler {
	
	public GameObject level_settings;

	public AudioSource audio;
	public AudioClip used_item_sound;

	public void OnPointerClick (PointerEventData eventData ) {
		if (PlayerPrefs.GetInt ("health_potion") > 0) {
			audio.PlayOneShot(used_item_sound, 0.7f);
			GameObject explosion = (GameObject)Instantiate (Resources.Load ("Explosion"), transform.position, transform.rotation);
			Destroy (explosion, 1);
			PlayerPrefs.SetFloat ("hp", PlayerPrefs.GetFloat ("hp") + 0.25f);
			PlayerPrefs.SetInt ("health_potion", PlayerPrefs.GetInt ("health_potion") - 1);
			Debug.Log ("iksir " + PlayerPrefs.GetInt ("health_potion"));
			PlayerPrefs.Save ();
			level_settings.GetComponent<Level_settings> ().user_health = PlayerPrefs.GetFloat ("hp");
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
