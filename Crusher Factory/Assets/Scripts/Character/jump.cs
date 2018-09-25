using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
	public float jump_strength;
	Rigidbody2D rb;
	public bool crusher_can_move;
	public bool jumpDownTrigger;

	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		Vector2 tempPos = transform.position;

		tempPos.y = Mathf.Clamp (tempPos.y, -500.0f, 500.0f);
		if (tempPos.y < 2.3f ) {
			crusher_can_move = true;
		} else{
			crusher_can_move = false;
		}

		if (crusher_can_move == false && jumpDownTrigger == false) {
			this.GetComponent<Rigidbody2D> ().simulated = false;
		}
		

	}

	public void jumpUp(){
		jumpDownTrigger = false;
		if(crusher_can_move==true){
			rb.AddForce (new Vector2(0,jump_strength*100));
		}
	}

	public void jumpDown(){
		jumpDownTrigger = true;
		this.GetComponent<Rigidbody2D> ().simulated = true;
		rb.AddForce (new Vector2(0,jump_strength*200*-1));

	}
		
}
