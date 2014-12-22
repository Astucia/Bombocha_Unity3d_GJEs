using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScreenScript : MonoBehaviour {

	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = PlayerPrefs.GetInt("Score") + "";
	}
	
	void tryAgain(){
		Application.LoadLevel("Prototype");
	}

	void goMenu(){
		Application.LoadLevel("mainmenu");
	}
}
