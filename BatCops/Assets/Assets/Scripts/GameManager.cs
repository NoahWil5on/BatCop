using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //------------------------------------------------------------------------------>>FIELDS<<
    // Robber Rat
    public GameObject robberRat, RRPrefab;

    [SerializeField]
    GameObject[] SpawnLocations;
    // Array of all exit points the Rat Thief is going for
    private List<GameObject> exitPoints;

    private int find;

    //------------------------------------------------------------------------------>>CONSTRUCTOR<<
    // Use this for initialization
    void Start () {

        //spawn da rat
        int spawnLoc = Random.Range(0, SpawnLocations.Length);
        robberRat = Instantiate(RRPrefab, SpawnLocations[spawnLoc].transform.position, SpawnLocations[spawnLoc].transform.rotation);
        // Adds all exit points to a private array list - used for Rat Thief's pathfinding
        exitPoints = new List<GameObject>();
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("ExitPoint"))
        {
            exitPoints.Add(g);
        }

        find = 0;

        robberRat.GetComponent<Vehicle>();
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(robberRat.transform.position, exitPoints[find].transform.position);
        //if () ;
    }
}
