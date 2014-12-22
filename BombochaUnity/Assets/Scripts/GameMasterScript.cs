using UnityEngine;
using System.Collections;

public class GameMasterScript : MonoBehaviour {

	public GameObject[] balls;
	public GameObject shooter;
	private Shoot shoot;

	// Use this for initialization
	void Start () { 
		shoot = shooter.GetComponent<Shoot>();
	}
	
	// Update is called once per frame
	void Update () {
	
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
