using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour {

	private Vector3 screenPoint;
	public Camera cameraPlayer;
	private bool isStop;

	// Use this for initialization
	void Start () {
		isStop = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void stop(){
		isStop = true;
	}

	void OnMouseDown(){
		if(!isStop){
			screenPoint = cameraPlayer.WorldToScreenPoint(gameObject.transform.position);
		}
	}

	void OnMouseDrag(){
		if(!isStop){
			Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 currentPosition = cameraPlayer.ScreenToWorldPoint(currentScreenPoint);
			transform.position = currentPosition.y > 0.1f ? currentPosition : new Vector3(currentPosition.x, 0.1f, currentPosition.z);
		}
	}
}
