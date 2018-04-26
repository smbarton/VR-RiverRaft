using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision col) {
        if(col.gameObject.tag == "Raft") {
            Debug.Log("Collided!");
            Messenger.Broadcast(GameEvent.GAME_OVER_LOSE);
        }
    }

    void Awake () {

    }

}
