using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public int score;
	public int ballCounter;
	public int ballValue;
	public int maxTime;
	private int leftTime;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		leftTime = 0;
		score = 0;
		scoreText.text = score + "";
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad > maxTime){
			gameOver();
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		if(other.tag == "Balls"){
			score += ballValue;
			scoreText.text = score + "";
			ballCounter++;
			if(ballCounter >= 5){
				gameOver();
			}
		}
	}

	public void gameOver(){
		leftTime = maxTime - (int)Time.timeSinceLevelLoad;
		PlayerPrefs.SetInt("Score", (score * ((leftTime/10) + 1)));
		Application.LoadLevel("GameOver");
	}
}
