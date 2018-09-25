using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StartApp;
using UnityEngine.EventSystems;

#if UNITY_ANDROID
public class VideoListenerImplementation : StartAppWrapper.VideoListener {
	
	public void onVideoCompleted() {
	}
}
#endif

public class RewardedGold : MonoBehaviour, IPointerClickHandler {
	public GameObject gold_menu;
	public GameObject gem_menu;
	public GameObject myText;
	public int amount;
	public bool gold;

	void Start () {
		#if UNITY_ANDROID
		VideoListenerImplementation videoListener = new VideoListenerImplementation ();
		StartAppWrapper.setVideoListener (videoListener);
		StartAppWrapper.loadAd(StartAppWrapper.AdMode.REWARDED_VIDEO);
		#endif
	}

	public void onFailedToReceiveAd(){
		this.GetComponent<Button>().interactable = false;
		myText.GetComponent<Text>().text = "ad is loading";
	}

	public void onReceiveAd(){
		this.GetComponent<Button>().interactable = true;
		myText.GetComponent<Text>().text = "watch ad";
	}

	public void OnPointerClick (PointerEventData eventData ) {
		#if UNITY_ANDROID
		StartAppWrapper.showAd();
		StartAppWrapper.loadAd(StartAppWrapper.AdMode.REWARDED_VIDEO);
		#endif

		if(Application.internetReachability != NetworkReachability.NotReachable)
		{
			if (gold == true) {
				gold_menu.SetActive (true);
				PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold") + amount);
				PlayerPrefs.Save ();
			} else {
				gem_menu.SetActive (true);
				PlayerPrefs.SetInt ("gem", PlayerPrefs.GetInt ("gem") + amount);
				PlayerPrefs.Save ();
			}
		}
	}
}

