using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbySceneController : MonoBehaviour {
	public GameObject popupOfJoinRoom;
	public GameObject popupOfError;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClicked(GameObject button) {
		switch(button.tag) {
		case "BUTTON_LISTROOM":
			showPopup(popupOfJoinRoom);
			break;
		case "BUTTON_OK":
			hidePopup(popupOfJoinRoom);
			MoveToRoomScene();
			break;
		case "BUTTON_CANCEL":
			hidePopup(popupOfJoinRoom);
			break;
		case "BUTTON_CONFIGURE":
			showPopup(popupOfError);
			break;
		case "BUTTON_CLOSE":
			hidePopup(popupOfError);
			break;
		case "BUTTON_MAKEROOM":
			MoveToCreateScene();
			break;
		default:
			print("There is no function for this button" + button);
			break;
		}
	}
	void MoveToCreateScene() {
		print("MoveToCreateScene");
		UnityEngine.SceneManagement.SceneManager.LoadScene("CreateScene");
	}

	void MoveToRoomScene() {
		print("MoveToRoomScene");
		UnityEngine.SceneManagement.SceneManager.LoadScene("RoomScene");
	}

	/**
	 * TODO:
	 * need parameter for join room
	 * ex) room info, user id, callback, ..
	 */
	void JoinRoom() {
		print("JoinRoom");
		MoveToRoomScene();
	}

	void showPopup(GameObject popup) {
		print("showPopup");
		popup.SetActive(true);
	}

	void hidePopup(GameObject popup) {
		print("hidePopup");
		popup.SetActive(false);
	}
}
