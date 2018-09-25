using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
	public string part;
	public GameObject target_object;
	public GameObject my_target;
	public GameObject my_target2;
	public int target_object_variety;
	public float max_target_object;
	public float min_target_object;
	public float delay_target_object;
	public float min_delay_target_object;

	public void start_routine(){
		StartCoroutine (create_count());
	}

	void Update () {
	}

	IEnumerator create_count(){
		while (true) {
			
			if (part == "part1") {
				for (int i = 0; i < Random.Range (min_target_object, max_target_object) + Time.fixedTime; i++) {
					if (target_object_variety == 1) {
						Debug.Log (target_object_variety + " ceşitlilik");
						if (Random.Range (0, 25) == 1) {
							Instantiate (Resources.Load ("gem"), transform.position, transform.rotation);
						} else if (Random.Range (0, 15) == 1) {
							Instantiate (Resources.Load ("gold"), transform.position, transform.rotation);
						} else {
							Instantiate (target_object, transform.position, transform.rotation);
						}
						yield return new WaitForSeconds (Random.Range (min_delay_target_object, delay_target_object));

					} else if (target_object_variety == 2) {
						if (Random.Range (0, 25) == 1) {
							Instantiate (Resources.Load ("gem"), transform.position, transform.rotation);
						} else if (Random.Range (0, 15) == 1) {
							Instantiate (Resources.Load ("gold"), transform.position, transform.rotation);
						} else if (Random.Range (0, 6) == 1) {
							Instantiate (Resources.Load ("tnt"), transform.position, transform.rotation);
						} else {
							Instantiate (target_object, transform.position, transform.rotation);
						}
						yield return new WaitForSeconds (Random.Range (min_delay_target_object, delay_target_object));
					}
				}
			}else if (part == "part2") {
				
				for (int i = 0; i < Random.Range (min_target_object, max_target_object) + Time.fixedTime; i++) {
					if (target_object_variety == 1) {
						Debug.Log (target_object_variety + " ceşitlilik");
						if (Random.Range (0, 5) == 1) {
							Debug.Log ("a1");
							Instantiate (my_target2, transform.position, transform.rotation);
						} else if (Random.Range (0, 5) == 2) {
							Debug.Log ("a2");
							Instantiate (my_target2, transform.position, transform.rotation);
						} else {
							Instantiate (my_target, transform.position, transform.rotation);
						}
						yield return new WaitForSeconds (Random.Range (min_delay_target_object, delay_target_object));

					} else if (target_object_variety == 2) {
						if (Random.Range (0, 5) == 1) {
							Debug.Log ("b1");
							Instantiate (my_target, transform.position, transform.rotation);
						} else if (Random.Range (0, 5) == 0) {
							Debug.Log ("b2");
							Instantiate (my_target, transform.position, transform.rotation);
						} else if (Random.Range (0, 5) == 2) {
							Debug.Log ("b3");
							Instantiate (Resources.Load ("tnt"), transform.position, transform.rotation);
						} else {
							Debug.Log ("normal");
							Instantiate (target_object, transform.position, transform.rotation);
						}
						yield return new WaitForSeconds (Random.Range (min_delay_target_object, delay_target_object));
					}
				}
			}
		}
	}
}
