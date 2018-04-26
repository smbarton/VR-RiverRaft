using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour {

    public ConstantForce cf;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake() {


        Messenger.AddListener(GameEvent.GAME_OVER_LOSE, OnGameOverLose);
        Messenger.AddListener(GameEvent.GAME_OVER_WIN, OnGameOverWin);
    }

    private void OnGameOverLose() {
        Debug.Log("StopMovement - OnGameOverLose");
        rb.isKinematic = true;
        cf.enabled = false;

    }

    private void OnGameOverWin() {
        rb.isKinematic = true;
        cf.enabled = false;
    }

    void OnDestroy() {
        Messenger.RemoveListener(GameEvent.GAME_OVER_LOSE, OnGameOverLose);
        Messenger.RemoveListener(GameEvent.GAME_OVER_WIN, OnGameOverWin);
    }


}
