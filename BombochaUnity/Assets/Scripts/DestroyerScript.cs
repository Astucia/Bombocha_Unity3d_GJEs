using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public int score;
	public int ballCounter;
	public int ballValue;
	public int maxTime;
	private int leftTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		if(other.tag == "Balls"){
			score += ballValue;
			ballCounter++;
			if(ballCounter >= 5){
				leftTime = maxTime - (int)Time.time;
				PlayerPrefs.SetInt("Score", (score * leftTime));
			}
		}
	}
}
