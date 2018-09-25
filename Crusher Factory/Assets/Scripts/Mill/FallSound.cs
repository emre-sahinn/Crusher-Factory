using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FallSound : MonoBehaviour {
	

	public AudioClip smashed_sound;
	public AudioSource source;

	void OnTriggerEnter2D(Collider2D col){
		Vector2 pos = transform.position;

		if (col.gameObject.tag == "movable") {
			source.PlayOneShot(smashed_sound, 0.4f);
		}else if (col.gameObject.tag == "smashed" || col.gameObject.name == "tnt(Clone)") {
			source.PlayOneShot(smashed_sound, 0.5f);
		}
			


	}
		
}
