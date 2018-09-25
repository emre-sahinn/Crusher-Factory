using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class onClick : MonoBehaviour, IPointerClickHandler {
	public GameObject star11;
	public GameObject star22;
	public GameObject star33;
	public string level_name;
	public GameObject my_level_text;
	public GameObject setting;
	public GameObject target_gameobject;
	public GameObject target_gameobject2;
	public GameObject gameobjects;
	public GameObject time;
	public int current_level=1;
	public GameObject panel1;
	GameObject destroyer;
	public GameObject generator;
	public int fixed_time=0;
	public GameObject level_select_menu;

	public AudioClip button_sound;
	public AudioClip unbutton_sound;
	public AudioSource source;

	public GameObject generator2;

	public GameObject starget_gameobject;
	public GameObject starget_gameobject2;

	void Update(){
		check_stars ();
		if (this.GetComponent<Button> ().interactable == true) {
			my_level_text.SetActive(true);
		} else {
			my_level_text.SetActive(false);
		}
	}
	public void OnPointerClick (PointerEventData eventData ) {
		if (this.GetComponent<Button> ().interactable == true) {
			source.PlayOneShot(button_sound, 1.0f);
			gameobjects.SetActive (true);
			destroyer = GameObject.Find ("destroyer");
			DestroyOnRefresh ();



			if (current_level == 1) {
				level1 ();
			} else if (current_level == 2) {
				level2 ();
			} else if (current_level == 3) {
				level3 ();
			} else if (current_level == 4) {
				level4 ();
			} else if (current_level == 5) {
				level5 ();
			} else if (current_level == 6) {
				level6 ();
			} else if (current_level == 7) {
				level7 ();
			} else if (current_level == 8) {
				level8 ();

			}else if (current_level == 9) {
				level9 ();
			}else if (current_level == 10) {
				level10 ();
			}else if (current_level == 11) {
				level11 ();
			}else if (current_level == 12) {
				level12 ();
			}else if (current_level == 13) {
				level13 ();
			}else if (current_level == 14) {
				level14 ();
			}else if (current_level == 15) {
				level15 ();
			}else if (current_level == 16) {
				level16 ();
			}
			destroyer.GetComponent<Destroyer> ().score = 0;
			level_select_menu.SetActive (false);
		}else source.PlayOneShot(unbutton_sound, 1.0f);
	}


	// Level Functions
	public void level1 () {
		time.GetComponent<time_set> ().playing_level = 1;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}
		fixed_time = Mathf.RoundToInt (Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 60;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 1 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		panel1.SetActive (true);
		destroyer.GetComponent<Destroyer> ().level_pass_score = 5;
		setting.GetComponent<Level_settings> ().Start_Level (target_gameobject, 1, 2.0f, 1.0f, 3f/2, 15.0f/2, 1.0f);
	}
	public void level2 () {
		time.GetComponent<time_set> ().playing_level = 2;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 90;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 2 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 15;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject,1,5.0f,1.0f,2.5f/2,10.0f/2,1.0f);
	}

	public void level3 () {
		time.GetComponent<time_set> ().playing_level = 3;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 120;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 3 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 25;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject,2,5.0f,1.0f,2.0f/2,5.0f/2,1.5f);
	}
	public void level4 () {
		time.GetComponent<time_set> ().playing_level = 4;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 150;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 4 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 30;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject,2,10.0f,5.0f,1.5f/2,4.0f/2,2f);
	}
	public void level5 () {
		time.GetComponent<time_set> ().playing_level = 5;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}
		fixed_time = Mathf.RoundToInt (Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 60;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 5 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		panel1.SetActive (true);
		destroyer.GetComponent<Destroyer> ().level_pass_score = 5;
		setting.GetComponent<Level_settings> ().Start_Level (target_gameobject2, 1, 2.0f, 1.0f, 3f/2, 15.0f/2, 1.0f);
	}
	public void level6 () {
		time.GetComponent<time_set> ().playing_level = 6;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 90;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 6 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 15;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject2,1,5.0f,1.0f,2.5f/2,10.0f/2,1.0f);
	}

	public void level7 () {
		time.GetComponent<time_set> ().playing_level = 7;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 120;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 7 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 25;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject2,2,5.0f,1.0f,2.0f/2,5.0f/2,1.5f);
	}

	public void level8 () {
		time.GetComponent<time_set> ().playing_level = 8;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 150;
		time.GetComponent<time_set> ().time2 = 0;
		generator.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 8 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 30;
		setting.GetComponent<Level_settings> ().Start_Level(target_gameobject2,2,10.0f,5.0f,1.5f/2,4.0f/2,1.5f);
	}

	/// <part1 end>
	/// ///////////////////////////
	/// </part2>
 
	public void level9 () {
		time.GetComponent<time_set> ().playing_level = 9;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}
		fixed_time = Mathf.RoundToInt (Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 60;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 9 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		panel1.SetActive (true);
		destroyer.GetComponent<Destroyer> ().level_pass_score = 5;
		setting.GetComponent<Level_settings> ().Start_Level2 (starget_gameobject, 1, 2.0f, 1.0f, 3f/4, 15.0f/4,2.0f);
	}

	public void level10 () {
		time.GetComponent<time_set> ().playing_level = 10;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 90;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 10 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 15;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject,1,2.0f, 1.0f,2.5f/4,10.0f/4,2.25f);
	}

	public void level11 () {
		time.GetComponent<time_set> ().playing_level = 11;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 120;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 11 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 25;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject,1,2.0f, 1.0f,2.0f/4,5.0f/4,2.5f);
	}
	public void level12 () {
		time.GetComponent<time_set> ().playing_level = 12;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 150;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 12 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 30;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject,1,2.0f, 1.0f,1.5f/4,4.0f/4,2.75f);
	}
	public void level13 () {
		time.GetComponent<time_set> ().playing_level = 13;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}
		fixed_time = Mathf.RoundToInt (Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 60;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 13 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		panel1.SetActive (true);
		destroyer.GetComponent<Destroyer> ().level_pass_score = 5;
		setting.GetComponent<Level_settings> ().Start_Level2 (starget_gameobject2, 2, 2.0f, 1.0f, 3f/4, 15.0f/4, 3.0f);
	}
	public void level14 () {
		time.GetComponent<time_set> ().playing_level = 14;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 90;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 14 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 15;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject2,2,2.0f,1.0f,2.5f/4,10.0f/4,3.25f);
	}

	public void level15 () {
		time.GetComponent<time_set> ().playing_level = 15;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 120;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 15 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 25;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject2,2,2.0f,1.0f,2.0f/4,5.0f/4,3.5f);
	}

	public void level16 () {
		time.GetComponent<time_set> ().playing_level = 16;
		if (setting.GetComponent<Level_settings> ().current_level == current_level) {
			setting.GetComponent<Level_settings> ().current_level = current_level;
		}

		fixed_time = Mathf.RoundToInt(Time.fixedTime);
		time.GetComponent<time_set> ().level_time = 150;
		time.GetComponent<time_set> ().time2 = 0;
		generator2.GetComponent<Generator> ().start_routine ();
		Debug.Log ("Level 16 is now active");
		time.GetComponent<time_set> ().start_timer = true;
		destroyer.GetComponent<Destroyer> ().level_pass_score = 30;
		setting.GetComponent<Level_settings> ().Start_Level2(starget_gameobject2,2,2.0f, 1.0f,1.5f/4,4.0f/4,4f);
	}


	//Destroy Function
	public void DestroyOnRefresh(){
		GameObject[] trashes = GameObject.FindGameObjectsWithTag("movable");
		foreach (GameObject trash in trashes) {
			Destroy (trash);
		}
		GameObject[] trashes2 = GameObject.FindGameObjectsWithTag("smashed");
		foreach (GameObject trash2 in trashes2) {
			Destroy (trash2);
		}
	}

	public void check_stars(){
		if (PlayerPrefs.GetInt (level_name) == 1) {
			star11.SetActive (true);
		} else if (PlayerPrefs.GetInt (level_name) == 2) {
			star11.SetActive (true);
			star22.SetActive (true);
		} else if (PlayerPrefs.GetInt (level_name) == 3) {
			star11.SetActive (true);
			star22.SetActive (true);
			star33.SetActive (true);
		} else {
			star11.SetActive (false);
			star22.SetActive (false);
			star33.SetActive (false);
		}
	}

}