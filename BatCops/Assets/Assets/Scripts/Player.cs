using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private GameObject enemy;
    public GameObject player;

	public float distanceDetect;
	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider coll)
    {
        if (!player.GetComponent<Backstab>().BackColl)
        {
            if (player.GetComponent<Backstab>().RatColl)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("DeadEnding");
            }
            else if (coll.CompareTag("Enemy"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("GoodEnd");
            }
        }
    }
}
