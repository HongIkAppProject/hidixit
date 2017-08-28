using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSceneManager : MonoBehaviour {

	public GameObject popup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClicked(GameObject button) {
		print("OnButtonClicked");
		switch(button.tag) {
		case "BUTTON_INVITE":
			showPopup();
			break;
		case "BUTTON_CONFIGURE":
			showPopup();
			break;
		case "BUTTON_CLOSE":
			hidePopup();
			break;
		case "BUTTON_STARTGAME":
			moveToGameScene();
			break;
		default:
			break;
		}
	}

	void showPopup() {
		print("showPopup");
		popup.SetActive(true);
	}

	void hidePopup() {
		print("hidePopup");
		popup.SetActive(false);
	}

	void moveToGameScene() {
		print("moveToGameScene");
		UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
	}
}
