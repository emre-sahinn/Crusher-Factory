using UnityEngine;
using UnityEngine.Advertisements;

public class Ad1: MonoBehaviour {
	[SerializeField]private string androidGameId = "2724927", iosGameId = "2724926";

	[SerializeField]private bool testMode;

	void Start ()      {
		string gameId = null;

		#if UNITY_ANDROID
			gameId = androidGameId;
		#elif UNITY_IOS
			gameId = iosGameId;
		#endif

		if (Advertisement.isSupported && !Advertisement.isInitialized) {
			Advertisement.Initialize (gameId, testMode);
		}
}
}