using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public int ballSelected;
	public GameObject[] balls;
	public int force;
	public GameObject gameMaster;
	private GameMasterScript gameMasterScript;
	private bool isMoving = false;
	public GameObject destroyer;
	private DestroyerScript destroyerScript;

	void Start(){
		ballSelected = 0;
		gameMasterScript = gameMaster.GetComponent<GameMasterScript>();
		destroyerScript = destroyer.GetComponent<DestroyerScript>();
	}



	void FixedUpdate(){


		if(Input.GetButtonDown("Jump") && !isMoving){
			isMoving = true;
			gameMasterScript.stopDragAndDrop();
			balls[ballSelected].rigidbody.AddForce(transform.parent.forward * force);
			balls[ballSelected].transform.parent = null;
			balls[ballSelected].rigidbody.useGravity = true;
			gameMasterScript.stopBalls();

		}
	}

	public void newMove(){
		ballSelected++;

		if(ballSelected == 4){
			destroyerScript.gameOver();
		}

		isMoving = false;
		for(int i =0; i< balls.Length; i++){
			if(i == ballSelected){
				balls[ballSelected].SetActive(true);
			}

		}
	}
}
