using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StartApp;
public class Level_settings : MonoBehaviour {

	public List<GameObject> buttons;



	public GameObject time_set_object;
	public int user_gold;
	public int user_gem;
	public int current_level = 1;
	public float user_health = 1.0f;
	public int hp_potion;
	public int time_potion;
	public int luck_box;

	public GameObject info;
	public GameObject info2;
	public GameObject game_end;
	public GameObject menu;
	public GameObject dead_menu;
	public GameObject gameobjects;
	public GameObject health;
	public GameObject money_text;
	public GameObject gem_text;
	public GameObject money_text_market;
	public GameObject gem_text_market;
	public GameObject level_text;
	public GameObject pause_menu;
	private static bool created = false;
	public bool isPaused;
	//Generator Settings
	public GameObject generator;

	//Mill Settings
	public GameObject mill;
	public GameObject mill2;

	public GameObject part1;
	public GameObject part2;
	public int part=1;
	public GameObject generator1;
	public GameObject generator2;





	//LANGUAGE//
	public List<GameObject> language;




	public void Start_Level (
		GameObject target_object,
		int target_object_variety,
		float max_target_object,
		float min_target_object,
		float min_delay_target_object,
		float delay_target_object,
		float mill_speed
	) {
			generator1.GetComponent<Generator> ().target_object = target_object;
			generator1.GetComponent<Generator> ().target_object_variety = target_object_variety;
			generator1.GetComponent<Generator> ().max_target_object = max_target_object;
			generator1.GetComponent<Generator> ().min_target_object = min_target_object;
			generator1.GetComponent<Generator> ().delay_target_object = delay_target_object;
			generator1.GetComponent<Generator> ().min_delay_target_object = min_delay_target_object;
			mill.GetComponent<treadmill> ().speed = mill_speed;
	}

	public void Start_Level2 (
		GameObject target_object,
		int target_object_variety,
		float max_target_object,
		float min_target_object,
		float min_delay_target_object,
		float delay_target_object,
		float mill_speed
	) {
			generator2.GetComponent<Generator> ().target_object = target_object;
			generator2.GetComponent<Generator> ().target_object_variety = target_object_variety;
			generator2.GetComponent<Generator> ().max_target_object = max_target_object;
			generator2.GetComponent<Generator> ().min_target_object = min_target_object;
			generator2.GetComponent<Generator> ().delay_target_object = delay_target_object;
			generator2.GetComponent<Generator> ().min_delay_target_object = min_delay_target_object;
			mill2.GetComponent<treadmill> ().speed = mill_speed;

	}
	
	void Update(){

		if (time_set_object.GetComponent<time_set>().playing_level > 8) {
			part = 2;
			part1.SetActive (false);
			part2.SetActive (true);
		} else {
			part = 1;
			part2.SetActive (false);
			part1.SetActive (true);
		}


		
		if (PlayerPrefs.GetFloat ("hp")  < 0.0f) {
			gameobjects.SetActive (false);
			menu.SetActive (true);
			dead_menu.SetActive (true);
			PlayerPrefs.SetFloat ("hp", 1);
			PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt("gold")/2);
			PlayerPrefs.SetInt ("gem", PlayerPrefs.GetInt("gem")/2);
			if(PlayerPrefs.GetInt("level")>1){
			PlayerPrefs.SetInt ("level", PlayerPrefs.GetInt("level")-1);
			}

		}


		money_text.GetComponent<Text>().text = PlayerPrefs.GetInt ("gold", 0).ToString ();
		gem_text.GetComponent<Text>().text = PlayerPrefs.GetInt ("gem", 0).ToString ();
		level_text.GetComponent<Text>().text = current_level.ToString();
		if (PlayerPrefs.GetFloat ("hp") > 1.0f) {
			PlayerPrefs.SetFloat ("hp", 1.0f);
			PlayerPrefs.Save ();
		}
		health.GetComponent<Image>().fillAmount = PlayerPrefs.GetFloat("hp");

		money_text_market.GetComponent<Text>().text = PlayerPrefs.GetInt ("gold", 0).ToString ();
		gem_text_market.GetComponent<Text>().text = PlayerPrefs.GetInt ("gem", 0).ToString ();

		if (current_level == 0) {
			current_level = 1;
			user_health = 1.0f;
			PlayerPrefs.SetInt ("level", 1);
			PlayerPrefs.SetFloat ("hp", 1);
		} else if (current_level == 1) {
			info.SetActive (true);
			info2.SetActive (false);
			for (int i = 0; i < 1; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 1; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 2) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 2; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 2; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 3) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 3; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 3; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 4) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 4; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 4; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 5) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 5; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 5; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 6) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 6; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 6; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 7) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 7; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 7; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}
		} else if (current_level == 8) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 8; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 8; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}




		} else if (current_level == 9) {
			info.SetActive (false);
			info2.SetActive (true);
			for (int i = 0; i < 9; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 9; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 10) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 10; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 10; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 11) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 11; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 11; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 12) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 12; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 12; i < 8; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 13) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 13; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 13; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 14) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 14; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 14; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 15) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 15; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 15; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 16) {
			info.SetActive (false);
			info2.SetActive (false);
			for (int i = 0; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = true;
			}
			for (int i = 16; i < 16; i++) {
				buttons [i].GetComponent<Button> ().interactable = false;
			}

		} else if (current_level == 17) {
			info.SetActive (false);
			info2.SetActive (false);
			game_end.SetActive (true);
			current_level = 16;
			PlayerPrefs.SetInt ("level", 16);
			PlayerPrefs.SetInt ("health_potion", 100);
			PlayerPrefs.SetInt ("time_potion", 100);
			PlayerPrefs.SetInt ("luck_box", 100);
		}else{
			info.SetActive (false);
			info2.SetActive (false);
		}
	}

	void Awake()
	{
		
		if (!created)
		{
			DontDestroyOnLoad(this.gameObject);
			created = true;
		}
	}

	void Start(){
		if (PlayerPrefs.GetInt ("tr") == 1) {
			//
			//
			//
			language [0].GetComponent<Text>().text = "yakinda yeni oyun modlari gelecek !";
			language [1].GetComponent<Text>().text = "Bedava gem ve altin";
			language [2].GetComponent<Text>().text = "Ezici";
			language [3].GetComponent<Text>().text = "Toplayici";
			language [4].GetComponent<Text>().text = "can iksiri";
			language [5].GetComponent<Text>().text = "Taze makine yağı !";
			language [6].GetComponent<Text>().text = "zaman iksiri";
			language [7].GetComponent<Text>().text = "Bu iksir zamanı yavaşlatır.";
			language [8].GetComponent<Text>().text = "Sans kutusu";
			language [9].GetComponent<Text>().text = "Can, zaman ikisiri çıkar. Oyun içinde kullanılır.";
			language [10].GetComponent<Text>().text = "Adet miktari";
			language [11].GetComponent<Text>().text = "Adet miktari";
			language [12].GetComponent<Text>().text = "Bundan aldiniz :";
			language [13].GetComponent<Text>().text = "Fakirsin";
			language [14].GetComponent<Text>().text = "Sahip oldugun altin veya gemler yetersiz ama ana menüden reklam izleyerek kazanabilirsin : )";
			language [15].GetComponent<Text>().text = "ahiret";
			language [16].GetComponent<Text>().text = "canin azaldigi icin geberdin. Mulkiyetin ve levelin azaldi. Simdi git can iksiri al ve kullan sunları !";
			language [17].GetComponent<Text>().text = "<---Tekrar canlan";
			language [18].GetComponent<Text>().text = "Mola";
			language [19].GetComponent<Text>().text = "Devam";
			language [20].GetComponent<Text>().text = "Pazar";
			language [21].GetComponent<Text>().text = "Menu";
			language [22].GetComponent<Text>().text = "Reklam";
			language [23].GetComponent<Text>().text = "Reklam icin butona tikla";
			language [24].GetComponent<Text>().text = "Reklam";
			language [25].GetComponent<Text>().text = "Reklam";
			language [26].GetComponent<Text>().text = "<---Markete don";
			language [27].GetComponent<Text>().text = "Adet miktari";
			language [28].GetComponent<Text>().text = "Bunu kazandin !";
			language [29].GetComponent<Text>().text = "Adet miktari";
			language [30].GetComponent<Text>().text = "Bunu kazandin !";
			language [31].GetComponent<Text>().text = "Yukari cekersen yukari cikar";
			language [32].GetComponent<Text>().text = "Asagi cekersen yere iner";
			language [33].GetComponent<Text>().text = "Sagligin";
			language [34].GetComponent<Text>().text = "Tenekeler siyah olana kadar vur";
			language [35].GetComponent<Text>().text = "ezici";
			language [36].GetComponent<Text>().text = "Envanter";
			language [37].GetComponent<Text>().text = "Zaman";
			language [38].GetComponent<Text>().text = "Skor";
			language [39].GetComponent<Text>().text = "Kirmizi Variller Buraya";
			language [40].GetComponent<Text>().text = "Acmak icin tikla";
			language [41].GetComponent<Text>().text = "Acmak icin tikla";
			language [42].GetComponent<Text>().text = "Yesil Variller Buraya";
			language [43].GetComponent<Text>().text = "TNT buraya";
			language [44].GetComponent<Text>().text = "SON";
			language [45].GetComponent<Text>().text = "Hikayenin sonu";
			language [46].GetComponent<Text>().text = "Tebrikler, oyunumu bitirdin! Bu oyunu yapmamda katkısı olan herkese teşekkür ediyorum. Evet, imkansız olan(en azından benim için) bölümü tamamladın. Bu oyunu yaparken bırakmayı çok düşündüm fakat oyun burda işte! İmkansızlıklara rağmen karşınızda bir oyun var. Asla pes etmeyin! Bye..";
		}
		/*
		PlayerPrefs.SetInt ("level", 1);
		PlayerPrefs.SetInt ("gold", 0);
		PlayerPrefs.SetInt ("gem", 0);
		PlayerPrefs.SetFloat ("hp",1);
		*/


		current_level = PlayerPrefs.GetInt ("level");
		user_health = PlayerPrefs.GetFloat ("hp");
	}

	public void Save_User_Data(){
		if (PlayerPrefs.HasKey ("gold") &&
			PlayerPrefs.HasKey ("gem") &&
			PlayerPrefs.HasKey ("level") &&
			PlayerPrefs.HasKey ("health_potion") &&
			PlayerPrefs.HasKey ("time_potion") &&
			PlayerPrefs.HasKey ("luck_box") 
		) {
			
			Debug.Log ("veri yüklendi");
			current_level = PlayerPrefs.GetInt ("level");
			user_health = PlayerPrefs.GetFloat ("hp");
			hp_potion = PlayerPrefs.GetInt ("health_potion");
			time_potion = PlayerPrefs.GetInt ("time_potion");
			luck_box = PlayerPrefs.GetInt ("luck_box");
			PlayerPrefs.SetFloat ("hp", user_health);
			PlayerPrefs.SetInt ("gold", time_set_object.GetComponent<time_set> ().gold+PlayerPrefs.GetInt("gold"));
			PlayerPrefs.SetInt ("gem", time_set_object.GetComponent<time_set> ().gems+PlayerPrefs.GetInt("gem"));
			PlayerPrefs.SetInt ("level", current_level);
			PlayerPrefs.SetInt ("health_potion", hp_potion);
			PlayerPrefs.SetInt ("time_potion", time_potion);
			PlayerPrefs.SetInt ("luck_box", luck_box);


		} else {
			Debug.Log ("veri yok");
			PlayerPrefs.SetFloat ("hp", 1);
			PlayerPrefs.SetInt ("gold", time_set_object.GetComponent<time_set> ().gold);
			PlayerPrefs.SetInt ("gem", time_set_object.GetComponent<time_set> ().gems);
			PlayerPrefs.SetInt ("level", 1);
			PlayerPrefs.SetInt ("health_potion", hp_potion);
			PlayerPrefs.SetInt ("time_potion", time_potion);
			PlayerPrefs.SetInt ("luck_box", luck_box);
		}
		PlayerPrefs.Save ();
	}

	void OnApplicationQuit () {
		Debug.Log ("gold miktarı "+PlayerPrefs.GetInt ("gold"));
		Debug.Log ("gem miktarı "+PlayerPrefs.GetInt ("gem"));
		Debug.Log ("level "+PlayerPrefs.GetInt ("level"));
		Debug.Log ("health "+PlayerPrefs.GetFloat ("hp"));
		Debug.Log ("hp_potion "+PlayerPrefs.GetInt ("health_potion"));
		Debug.Log ("time_potion "+PlayerPrefs.GetInt ("time_potion"));
		Debug.Log ("luck_box "+PlayerPrefs.GetInt ("luck_box"));
	}

	void OnApplicationFocus(bool hasFocus)
	{
		isPaused = !hasFocus;
		if (time_set_object.GetComponent<time_set> ().start_timer == true) {
			if (isPaused == true) {
				Time.timeScale = 0;
				pause_menu.SetActive (true);
			}
		}
	}

}
