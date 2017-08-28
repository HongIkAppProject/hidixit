using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// On button clicked
	public void OnButtonClicked() {
		moveToRoomScene();
	}

	void moveToRoomScene() {
		SceneManager.LoadScene("RoomScene");
	}
}
