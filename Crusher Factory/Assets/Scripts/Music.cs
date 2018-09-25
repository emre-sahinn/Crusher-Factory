using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
	public AudioSource audio;
	public AudioClip[] soundtrack;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		if (!audio.playOnAwake)
		{
			audio.clip = soundtrack[Random.Range(0, soundtrack.Length)];
			audio.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying)
		{
			audio.clip = soundtrack[Random.Range(0, soundtrack.Length)];
			audio.Play();
		}
	}
		
}
