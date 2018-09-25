using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class time_active : MonoBehaviour, IPointerClickHandler {

	public GameObject level_settings;

	public AudioSource audio;
	public AudioClip used_item_sound;

	public void OnPointerClick (PointerEventData eventData ) {
		if (PlayerPrefs.GetInt ("time_potion") > 0) {
			audio.PlayOneShot(used_item_sound, 0.7f);
			GameObject explosion = (GameObject)Instantiate (Resources.Load ("Explosion"), transform.position, transform.rotation);
			Destroy (explosion, 1);
			StartCoroutine (slow_down_time ());
			PlayerPrefs.SetInt ("time_potion", PlayerPrefs.GetInt ("time_potion") - 1);
			PlayerPrefs.Save ();
		}
	}

	IEnumerator slow_down_time(){
		Time.timeScale = 0.5f;
		yield return new WaitForSeconds (10);
		Time.timeScale = 1f;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (Time.timeScale);
	}
}
