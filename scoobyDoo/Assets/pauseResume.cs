using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseResume : MonoBehaviour {

	public bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
	}

	// Update is called once per frame
	void Update () {


	}
	public void pauseandResume(){
		pause = !pause;
		if (!pause) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
		}
	}
}