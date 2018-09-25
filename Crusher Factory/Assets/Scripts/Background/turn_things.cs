using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_things : MonoBehaviour {
	Transform turn;

	public GameObject target;
	float degree;
	public float speed_rate;

	public bool scale_active;
	public float scale;
	float size;
	public float scale_rate;
	public float min_scale=0.8f;
	public float max_scale=1.2f;
	// Use this for initialization
	void Start () {
		turn = target.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (scale_active == true) {
			if (scale == 1) {
				size += scale_rate * Time.deltaTime/10;
				turn.localScale = new Vector3 (1 + size, 1 + size, 0);
			} else if (scale == 2) {
				size -= scale_rate * Time.deltaTime/10;
				turn.localScale = new Vector3 (1 + size, 1 + size, 0);
			}

			if (turn.localScale.x > max_scale) {
				scale = 2;
			} else if (turn.localScale.x <min_scale) {
				scale = 1;
			}

		}

		degree=speed_rate*Time.deltaTime*10;
		turn.Rotate(new Vector3(0,0,degree));
	}
}
