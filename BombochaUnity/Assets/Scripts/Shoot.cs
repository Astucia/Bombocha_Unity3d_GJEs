using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject ball;
	public int force;
	private bool isMoving = false;

	void FixedUpdate(){
		if(Input.GetButtonDown("Jump") && !isMoving){
			isMoving = true;
			ball.rigidbody.AddForce(transform.parent.forward * force);
			ball.transform.parent = null;
			ball.rigidbody.useGravity = true;
		}
	}
}
