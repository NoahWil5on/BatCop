using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {
	public float speed;
    // Use this for initialization

    public static SimpleMove instance = null;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);


    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("up") || Input.GetKey(KeyCode.W))
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+speed);
		if(Input.GetKey("down") || Input.GetKey(KeyCode.S))
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-speed);
		if(Input.GetKey("left") || Input.GetKey(KeyCode.A))
			transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);
		if(Input.GetKey("right") || Input.GetKey(KeyCode.D))
			transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);
	}
}
