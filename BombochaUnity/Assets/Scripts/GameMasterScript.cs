using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMasterScript : MonoBehaviour {

	public GameObject[] balls;
	public GameObject shooter;
	private Shoot shoot;
	public Text timeText;
	public int maxTime;
	private int leftTime;

	// Use this for initialization
	void Start () { 
		leftTime = 60;
		shoot = shooter.GetComponent<Shoot>();
		timeText.text = leftTime + "";
	}
	
	// Update is called once per frame
	void Update () {
		leftTime = maxTime - (int)Time.time;
		timeText.text = leftTime + "";

	}

	public void stopBalls(){
		Debug.Log("entre");
		StartCoroutine("stopBallsCoroutine");
	}

	IEnumerator stopBallsCoroutine(){
		yield return new WaitForSeconds(12);
		foreach(GameObject ball in balls){
			if(ball != null){
				ball.rigidbody.velocity = Vector3.zero;
				ball.rigidbody.angularVelocity = Vector3.zero;
				Debug.Log("stop");
			}
		}
		shoot.newMove();
	}
}
