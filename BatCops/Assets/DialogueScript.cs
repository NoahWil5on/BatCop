using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogueScript : MonoBehaviour {


    [SerializeField]
    AudioClip[] clips;
    public Text text;
    [SerializeField]
    string[] strings;

    int curClip = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)){
            
            if (curClip < 23)
            {
                text.text = strings[curClip];
                GetComponent<AudioSource>().clip = clips[curClip];
                GetComponent<AudioSource>().Play();
            }
            curClip += 1;

        }
        if(curClip >= 6)
        {
            SceneManager.LoadScene("Batcops");
        }
	}
}
