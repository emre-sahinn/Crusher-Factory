using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEverything : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		Vector2 pos = transform.position;
			Destroy (col.gameObject);
		}
	
}
