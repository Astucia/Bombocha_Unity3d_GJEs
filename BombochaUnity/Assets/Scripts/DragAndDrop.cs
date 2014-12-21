using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour {

	private Vector3 screenPoint;
	public Camera cameraPlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		screenPoint = cameraPlayer.WorldToScreenPoint(gameObject.transform.position);
	}

	void OnMouseDrag(){
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = cameraPlayer.ScreenToWorldPoint(currentScreenPoint);
		transform.position = currentPosition.y > 0.1f ? currentPosition : new Vector3(currentPosition.x, 0.1f, currentPosition.z);
	}
}
