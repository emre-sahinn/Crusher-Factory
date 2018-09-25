using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Switch : MonoBehaviour, IPointerClickHandler {
	public int number = 1;
	public GameObject my_switch;
	public Sprite my_sprite;
	public Sprite my_sprite2;

	public GameObject gate;

	public AudioSource source;
	public AudioClip button_sound;
	public AudioClip unbutton_sound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick (PointerEventData eventData ) {
		number += 1;
		if (number == 1) {
			source.PlayOneShot(unbutton_sound, 0.7f);
			my_switch.GetComponent<Image> ().sprite = my_sprite;
			gate.GetComponent<Image> ().fillAmount = 1;
			gate.GetComponent<BoxCollider2D> ().isTrigger = false;
		} else if (number == 2) {
			source.PlayOneShot(button_sound, 0.7f);
			my_switch.GetComponent<Image> ().sprite = my_sprite2;
			number = 0;
			gate.GetComponent<Image> ().fillAmount = 0;
			gate.GetComponent<BoxCollider2D> ().isTrigger = true;
		}
	}
}
