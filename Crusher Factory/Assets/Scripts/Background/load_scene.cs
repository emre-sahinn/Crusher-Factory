using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load_scene : MonoBehaviour {
	public int scene_number;
	public bool scene_load = false;
	// Use this for initialization
	public void load_level () {
		scene_load = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (scene_load == true) {
			SceneManager.LoadScene (scene_number);
		}
	}
}
