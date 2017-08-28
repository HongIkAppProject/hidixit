using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClicked(GameObject button) {
		switch(button.tag) {
		case "BUTTON_HOME":
			moveToMainScene();
			break;
		default:
			print("No action for this button");
			break;
		}
	}

	void moveToMainScene() {
		UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
	}
}
