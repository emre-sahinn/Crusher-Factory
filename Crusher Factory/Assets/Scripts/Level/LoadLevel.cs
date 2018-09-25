using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour, IPointerClickHandler {
	public bool quit_game;
	public string level;
	public void OnPointerClick (PointerEventData eventData ) {
		if (quit_game == true) {
			Application.Quit ();
		} else {
			SceneManager.LoadScene (level);
		}
	}
}
