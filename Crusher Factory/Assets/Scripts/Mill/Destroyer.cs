using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Destroyer : MonoBehaviour {
	
	public GameObject score_text;
	public int score;
	public int level_pass_score;


	void OnTriggerEnter2D(Collider2D col){
		Vector2 pos = transform.position;

		if (col.gameObject.tag == "movable") {
			if (col.gameObject.name == "tnt(Clone)" || col.gameObject.name == "gem(Clone)" || col.gameObject.name == "gold(Clone)") {
				score += 1;
				Destroy (col.gameObject);
			} else {
				score -= 1;
				Destroy (col.gameObject);
			}
		}else if (col.gameObject.tag == "smashed" ) {
			score += 1;
			Destroy (col.gameObject);
		}
			


	}

	void Update(){
		score_text.GetComponent<Text> ().text = score.ToString()+"/"+level_pass_score.ToString();
	}
}
