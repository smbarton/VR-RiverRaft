using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("MainLevel");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
