using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.Advertisements;
using StartApp;

public class onClickActivate : MonoBehaviour, IPointerClickHandler {
	public List<GameObject> activate;
	public List<GameObject> deactivate;
	public GameObject level_settings;
	public bool showAds=true;
	// Use this for initialization

	void Awake(){
		#if UNITY_ANDROID
		StartAppWrapper.init();
		StartAppWrapper.loadAd();
		#endif
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnPointerClick (PointerEventData eventData ) {
		Time.timeScale = 1;
		if (showAds == true) {
			#if UNITY_ANDROID
			StartAppWrapper.showAd ();
			StartAppWrapper.loadAd ();
			#endif
		}
		/*if (Advertisement.IsReady ()) {
			Advertisement.Show ();
		}*/
		level_settings.GetComponent<Level_settings> ().Save_User_Data ();
		for (int i = 0; i < activate.Count; i++) {
			activate[i].SetActive (true);
		}

		for (int i = 0; i < deactivate.Count; i++) {
			deactivate[i].SetActive (false);
		}
	}
}
