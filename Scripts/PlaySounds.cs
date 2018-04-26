using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour {

    //public AudioSource paddle;
    public AudioSource crash;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake() {
        Messenger.AddListener(GameEvent.GAME_OVER_LOSE, OnCrash);
    }

    private void OnCrash() {
        Debug.Log("PlaySounds - OnCrash - sound play");
        crash.Play();
    }

    void OnDestroy() {
        Messenger.RemoveListener(GameEvent.GAME_OVER_LOSE, OnCrash);
    }
}
