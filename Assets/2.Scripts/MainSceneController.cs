﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour {

	public GameObject popup;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClicked() {
		print("OnButtonClicked()");
		popup.SetActive(true);
	}

	public void MoveToLobbyScene() {
		SceneManager.LoadScene("LobbyScene");
	}
}
