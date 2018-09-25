using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crusher : MonoBehaviour {
	public float speed;
	public GameObject score_text;
	public GameObject health;
	public GameObject level_sett;
	public GameObject message_object;
	public float size_x=1.6f;
	public float size_y=0.4f;

	public AudioClip barrel_sound;
	public AudioClip barrel_sound2;
	public AudioClip barrel_sound3;
	public AudioClip explosion_sound;
	public AudioClip glass_sound;
	public AudioSource source;

	void OnTriggerEnter2D(Collider2D col){
		Vector2 pos = transform.position;
		if (col.gameObject.tag == "movable") {
			if (col.gameObject.name == "luck_box(Clone)") {
				GameObject explosion = (GameObject)Instantiate (Resources.Load("ExplosionBig"), col.transform.position, col.transform.rotation);
				Destroy (col.gameObject);
				Destroy (explosion.gameObject,1);
				int congrats_value = Random.Range (0, 5);
				Debug.Log ("congrat= " + congrats_value);
				if (congrats_value > 0) {
					if (congrats_value == 1 || congrats_value == 2) {
						int time_potion = Random.Range (1, 5);
						Debug.Log ("time_potion= " + time_potion);
						PlayerPrefs.SetInt ("time_potion", PlayerPrefs.GetInt ("time_potion") + time_potion);
						PlayerPrefs.Save ();
						message_object.SetActive (true);
						message_object.GetComponent<message> ().start_command ();
						if (PlayerPrefs.GetInt ("tr") == 1) {
							message_object.GetComponent<message> ().messageText = "Tebrikler! \n"+time_potion+" Zaman iksiri buldun!";
						} else {
							message_object.GetComponent<message> ().messageText = "congrats! you just found:\n"+time_potion+" Time Potion!";
						}

					} else {
						int hp_potion = Random.Range (1, 10);
						Debug.Log ("hp_potion= " + hp_potion);
						PlayerPrefs.SetInt ("health_potion", PlayerPrefs.GetInt ("health_potion") + hp_potion);
						PlayerPrefs.Save ();
						message_object.SetActive (true);
						message_object.GetComponent<message> ().start_command ();
						if (PlayerPrefs.GetInt ("tr") == 1) {
							message_object.GetComponent<message> ().messageText = "Tebrikler! \n"+hp_potion+" Can iksiri buldun!";
						} else {
							message_object.GetComponent<message> ().messageText = "congrats! you just found:\n"+hp_potion+" Health Potion!";
						}

					}

				}
			}
			Transform trans=col.gameObject.GetComponent<Transform> ();
			if (trans.lossyScale.x < size_x && trans.lossyScale.y > size_y ) {

				if (col.gameObject.name == "Barrel(Clone)") {
					source.PlayOneShot(barrel_sound, 0.75f);
					trans.localScale -= (new Vector3 (-1 * speed * Time.deltaTime, speed * Time.deltaTime, 0));
				}

				if (col.gameObject.name == "Barrel_red(Clone)") {
					source.PlayOneShot(barrel_sound2, 1.0f);
					trans.localScale -= (new Vector3 (-1f * speed/2 * Time.deltaTime, speed/2 * Time.deltaTime, 0));
				}



				if (col.gameObject.name == "tnt(Clone)") {
					source.PlayOneShot(explosion_sound, 0.75f);
					GameObject explosion = (GameObject)Instantiate (Resources.Load("Explosion"), col.transform.position, col.transform.rotation);
					Destroy (col.gameObject);
					Destroy (explosion.gameObject,1);
					if (health.GetComponent<Image> ().fillAmount > 0) {
						health.GetComponent<Image> ().fillAmount -= 0.2f;
						PlayerPrefs.SetFloat ("hp", PlayerPrefs.GetFloat ("hp") - 0.2f);
					} else {
						score_text.GetComponent<Text> ().text = "Game Over";
					}
				}
			} else{
				if (col.gameObject.name == "gold(Clone)") {
					source.PlayOneShot(glass_sound, 0.75f);
					message_object.SetActive (true);
					message_object.GetComponent<message> ().start_command ();
					if (PlayerPrefs.GetInt ("tr") == 1) {
						message_object.GetComponent<message> ().messageText = "Tebrikler! \n"+"5"+" Altin kazandin!";
					} else {
						message_object.GetComponent<message> ().messageText = "congrats! you earned:\n"+"5"+" Gold!";
					}

					GameObject explosion = (GameObject)Instantiate (Resources.Load("GoldExplosion"), col.transform.position, col.transform.rotation);
					Destroy (col.gameObject);
					Destroy (explosion.gameObject,1);
					PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold") + 5);
					PlayerPrefs.Save ();
				}

				if (col.gameObject.name == "gem(Clone)") {
					source.PlayOneShot(glass_sound, 1f);
					message_object.SetActive (true);
					message_object.GetComponent<message> ().start_command ();
					if (PlayerPrefs.GetInt ("tr") == 1) {
						message_object.GetComponent<message> ().messageText = "Tebrikler! \n"+"1"+" Gem kazandin!";
					} else {
						message_object.GetComponent<message> ().messageText = "congrats! you earned:\n"+"1"+" Gem!";
					}

					GameObject explosion = (GameObject)Instantiate (Resources.Load("GoldExplosion"), col.transform.position, col.transform.rotation);
					Destroy (col.gameObject);
					Destroy (explosion.gameObject,1);
					PlayerPrefs.SetInt ("gem", PlayerPrefs.GetInt ("gem") + 1);
					PlayerPrefs.Save ();
				}

				if (col.gameObject.name == "Barrel(Clone)") {
					source.PlayOneShot(barrel_sound3, 0.25f);
				}

				if (col.gameObject.name == "Barrel_red(Clone)") {
					source.PlayOneShot(barrel_sound3, 0.25f);
				}

				col.GetComponent<SpriteRenderer> ().color = Color.gray;
				col.gameObject.tag="smashed";
			}
		}
	}
		
}
