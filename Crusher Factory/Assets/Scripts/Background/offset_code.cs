using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset_code : MonoBehaviour {
	Material material;
	Vector2 offset;
	public float speed=1;
	public int x_velocity,y_velocity;
	// Use this for initialization
	void Start () {
		material = GetComponent<Renderer>().material;
		offset = new Vector2 (x_velocity, y_velocity);
	}
	
	// Update is called once per frame
	void Update () {
		material.mainTextureOffset += offset * Time.deltaTime*speed;
	}
}
