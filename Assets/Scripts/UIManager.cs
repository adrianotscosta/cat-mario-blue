using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject gameOver, gameComplete;
	public static UIManager instance;

	void Awake () {
		if(instance == null) {
			instance = this;
			//DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
		
	void Start () {
		gameOver.SetActive (false);
		gameComplete.SetActive (false);
	}
		
	public void GameOverUI () {
		gameOver.SetActive (true);
	}

	public void GameCompleteUI () {
		gameComplete.SetActive (true);
	}
}
