using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject enemy;
	public float distanceDetect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(Vector3.Magnitude(enemy.transform.position-transform.position)) < distanceDetect){
			UnityEngine.SceneManagement.SceneManager.LoadScene("GoodEnd");
		}
	}
}
