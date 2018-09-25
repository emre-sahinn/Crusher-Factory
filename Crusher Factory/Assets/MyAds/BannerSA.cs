using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartApp;

public class BannerSA : MonoBehaviour {

	public List<GameObject> menus;
	public GameObject position;
	// Use this for initialization
	void Start () {
		Vector3 position1 = position.transform.position;
		#if UNITY_ANDROID
		StartAppWrapper.addBanner( 
			StartAppWrapper.BannerType.AUTOMATIC,
			StartAppWrapper.BannerPosition.TOP);
		if(Application.internetReachability != NetworkReachability.NotReachable)
		{
			for(int i=0;i<menus.Count;i++){
				Debug.Log(i);
				Vector3 pos = menus[i].transform.position;
				pos.y+=position1.y;
			}
		}
		#endif
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
