using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_set : MonoBehaviour {
	public GameObject settings;

	public bool start_timer = false;
	public GameObject destroyer;
	public GameObject gameobjects;
	public GameObject level_end_panel;

	public float level_time=10;
	public float time2=0;

	public GameObject star1;
	public GameObject star2;
	public GameObject star3;

	public int star_amount = 0;

	public int playing_level = 1;

	public int gold = 0;
	public int gems = 0;
	public int gold_reward = 0;
	public int gems_reward = 0;
	public GameObject gold_text;
	public GameObject gems_text;

	public AudioClip level_end_sound;
	public AudioSource source;

	void Start () {
		
	}
	
	void Update () {
		Destroyer destroyer_c = destroyer.GetComponent<Destroyer> ();
		if (start_timer == true) {
			time2 += 1 *Time.deltaTime ;
			this.GetComponent<Text>().text = Mathf.RoundToInt(level_time-time2).ToString();
		}

		if (Mathf.RoundToInt (level_time - time2) <= 0) {
			source.PlayOneShot(level_end_sound, 1f);
			level_end_panel.SetActive (true);
			start_timer = false;
			level_time = 100000;
			if (destroyer_c.score > destroyer_c.level_pass_score / 2) {
				
				star_amount = 1;
				gold_reward = 10 * playing_level;
				gold += gold_reward;
				gold_text.GetComponent<Text> ().text = gold_reward.ToString ();
				if (destroyer_c.score == destroyer_c.level_pass_score / 2 || destroyer_c.score > destroyer_c.level_pass_score / 2 + destroyer_c.level_pass_score / 4) {
					star_amount = 2;
					gold_reward = 20 * playing_level;
					gold += gold_reward;
					gold_text.GetComponent<Text> ().text = gold_reward.ToString ();
					if (destroyer_c.score >= destroyer_c.level_pass_score) {
						star_amount = 3;
						gold_reward = 30 * playing_level;
						gems_reward = 1 * playing_level;
						gold += gold_reward;
						gems += gems_reward;
						gold_text.GetComponent<Text> ().text = gold_reward.ToString ();
						gems_text.GetComponent<Text> ().text = gems_reward.ToString ();
						if (settings.GetComponent<Level_settings> ().current_level == playing_level) {
							settings.GetComponent<Level_settings> ().current_level += 1;
							settings.GetComponent<Level_settings> ().Save_User_Data ();
							PlayerPrefs.SetInt ("level", PlayerPrefs.GetInt ("level") + 1);
							PlayerPrefs.Save ();

						} else {
							settings.GetComponent<Level_settings> ().Save_User_Data ();
						}
					}
				}
				if (star_amount == 1) {
					star1.SetActive (true);
					star2.SetActive (false);
					star3.SetActive (false);
				}else if (star_amount == 2) {
					star1.SetActive (true);
					star2.SetActive (true);
					star3.SetActive (false);
				}else if (star_amount == 3) {
					star1.SetActive (true);
					star2.SetActive (true);
					star3.SetActive (true);
				}


				if (playing_level == 1) {
					PlayerPrefs.SetInt ("level1", star_amount);
				}else if (playing_level == 2) {
					PlayerPrefs.SetInt ("level2", star_amount);
				}else if (playing_level == 3) {
					PlayerPrefs.SetInt ("level3", star_amount);
				}else if (playing_level == 4) {
					PlayerPrefs.SetInt ("level4", star_amount);
				}else if (playing_level == 5) {
					PlayerPrefs.SetInt ("level5", star_amount);
				}else if (playing_level == 6) {
					PlayerPrefs.SetInt ("level6", star_amount);
				}else if (playing_level == 7) {
					PlayerPrefs.SetInt ("level7", star_amount);
				}else if (playing_level == 8) {
					PlayerPrefs.SetInt ("level8", star_amount);
				}else if (playing_level == 9) {
					PlayerPrefs.SetInt ("level9", star_amount);
				}else if (playing_level == 10) {
					PlayerPrefs.SetInt ("level10", star_amount);
				}else if (playing_level == 11) {
					PlayerPrefs.SetInt ("level11", star_amount);
				}else if (playing_level == 12) {
					PlayerPrefs.SetInt ("level12", star_amount);
				}else if (playing_level == 13) {
					PlayerPrefs.SetInt ("level13", star_amount);
				}else if (playing_level == 14) {
					PlayerPrefs.SetInt ("level14", star_amount);
				}else if (playing_level == 15) {
					PlayerPrefs.SetInt ("level15", star_amount);
				}else if (playing_level == 16) {
					PlayerPrefs.SetInt ("level16", star_amount);
				}
			}
			Debug.Log ("gold=" + gold + " gems=" + gems);
			gameobjects.SetActive (false);
		}
		gold = 0;
		gems = 0;
	}

}
