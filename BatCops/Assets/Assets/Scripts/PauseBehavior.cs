using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehavior : MonoBehaviour {
	public GameObject canvas;
	// Use this for initialization
	void Start () {
		canvas.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(canvas.activeInHierarchy){
				canvas.SetActive(false);
			}
			else{
				canvas.SetActive(true);
			}
		}
	}
}
