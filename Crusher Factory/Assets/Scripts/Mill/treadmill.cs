using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treadmill : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		Vector2 pos = transform.position;
		if (col.gameObject.tag == "movable" || col.gameObject.tag == "smashed") {
			Transform trans=col.gameObject.GetComponent<Transform> ();
			trans.position += (new Vector3(-1*speed*Time.deltaTime,speed*Time.deltaTime/2,0));
		}
	}

	void OnTriggerExit2D(Collider2D col){
		Vector2 pos = transform.position;
		if (col.gameObject.tag == "movable" || col.gameObject.tag == "smashed") {
			Rigidbody2D phy=col.gameObject.GetComponent<Rigidbody2D> ();
			phy.constraints = RigidbodyConstraints2D.None;
		}
	}


}
