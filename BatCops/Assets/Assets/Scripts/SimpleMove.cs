using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {
	public float speed;
    // Use this for initialization
	public Vector3 startPos;
    public static SimpleMove instance = null;
	public GameObject canvas;

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
       // DontDestroyOnLoad(gameObject);

		startPos = transform.position;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position;
		if(Input.GetKey("up") || Input.GetKey(KeyCode.W))
			newPos = new Vector3(newPos.x,newPos.y,newPos.z+speed);
		if(Input.GetKey("down") || Input.GetKey(KeyCode.S))
			newPos = new Vector3(newPos.x,newPos.y,newPos.z-speed);
		if(Input.GetKey("left") || Input.GetKey(KeyCode.A))
			newPos = new Vector3(newPos.x-speed,newPos.y,newPos.z);
		if(Input.GetKey("right") || Input.GetKey(KeyCode.D))
			newPos = new Vector3(newPos.x+speed,newPos.y,newPos.z);
		GetComponent<Rigidbody>().MovePosition(newPos);

	}
}
