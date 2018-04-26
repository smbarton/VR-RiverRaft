using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Raft") {
            Debug.Log("VICTORY!");
            Messenger.Broadcast(GameEvent.GAME_OVER_WIN);
        }
    }

    void Awake() {
        
    }
}
