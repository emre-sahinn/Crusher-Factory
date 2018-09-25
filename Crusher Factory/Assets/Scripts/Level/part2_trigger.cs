using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part2_trigger : MonoBehaviour {
	public GameObject destroyer;
	public bool barrel_color;
	void OnTriggerEnter2D(Collider2D col){
		Vector2 pos = transform.position;
		Debug.Log ("isim"+ col.gameObject.name);
		if (col.gameObject.tag == "movable") {
			if (col.gameObject.name == "SmashedRedBarrel(Clone)" && barrel_color == true  || col.gameObject.name == "gem(Clone)" || col.gameObject.name == "gold(Clone)"){
				destroyer.GetComponent<Destroyer> ().score += 1;
				Destroy (col.gameObject);
			}else if (barrel_color == false && col.gameObject.name == "SmashedBarrel(Clone)" || col.gameObject.name == "gem(Clone)" || col.gameObject.name == "gold(Clone)"){
				destroyer.GetComponent<Destroyer> ().score += 1;
				Destroy (col.gameObject);
			}else{
				destroyer.GetComponent<Destroyer> ().score -= 1;
				Destroy (col.gameObject);
			}
		}
	}
}