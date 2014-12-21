using UnityEngine;
using System.Collections;

public class MenuMusik : MonoBehaviour {

    GameObject Camara = GameObject.Find("Main Camera");

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        Object.DontDestroyOnLoad(this);
        if (!this.audio.isPlaying)
        {
            this.audio.Play();
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Application.loadedLevelName == "Prototype" && this.audio.isPlaying)
        {
            this.audio.Stop();
        }
        //else
        //{
        //    this.transform.position = Camara.transform.position;
        //}
	}
}
