using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class music : MonoBehaviour, IPointerClickHandler {
	public AudioSource audioObject;
	private int click_no;
	public void OnPointerClick (PointerEventData eventData ) {
		audioObject.mute=!audioObject.mute;
	}
}
