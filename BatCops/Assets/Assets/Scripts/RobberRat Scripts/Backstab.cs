using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backstab : MonoBehaviour {

    bool backColl;


    public bool BackColl
    {
        get { return backColl; }
    }

	// Use this for initialization
	void Start () {
        backColl = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //checking to see if the rat collides with the back of you
    void OnTriggerEnter(Collider other)
    {
        backColl = true;

        if (other.CompareTag("Enemy"))
            {
            UnityEngine.SceneManagement.SceneManager.LoadScene("DeadEnding");
        }

        backColl = false;
    }
}
