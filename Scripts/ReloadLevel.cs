using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadCurrentLevel() {
        SceneManager.LoadScene("LoadSceneML");
        Debug.Log("LevelReloaded");
    }

    void Awake() {

        Messenger.AddListener(GameEvent.GAME_OVER_LOSE, OnGameOverLose);
        Messenger.AddListener(GameEvent.GAME_OVER_WIN, OnGameOverWin);
    }

    private void OnGameOverLose() {
        Debug.Log("ReloadLevel - OnGameOVerLose");
        StartCoroutine(DelayLoad());
    }

    private void OnGameOverWin() {
        StartCoroutine(DelayLoad());

    }

    IEnumerator DelayLoad() {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
        LoadCurrentLevel();
    }

    void OnDestroy() {
        Messenger.RemoveListener(GameEvent.GAME_OVER_LOSE, OnGameOverLose);
        Messenger.RemoveListener(GameEvent.GAME_OVER_WIN, OnGameOverWin);
    }
}
