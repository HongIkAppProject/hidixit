using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class S00_LobbyManager : NetworkLobbyManager
{
    protected RectTransform currentMenu;
    public RectTransform p20_LobbyMenu;
    public delegate void BackButtonDelegate();
    public BackButtonDelegate backDelegate;
    public bool _isMatchmaking = false;
    public static S00_LobbyManager instance = null;

    void Awake()
    {
        // FIXME : 
        // if (instance = null) instance = this;
        // else if (instance != this) Destroy(gameObject);
        // DontDestroyOnLoad(gameObject);
    }


    // FIXME : all
    public void ChangeTo(RectTransform newPanel)
    {
        if (currentMenu != null)
            currentMenu.gameObject.SetActive(false);

        if (newPanel != null)
            newPanel.gameObject.SetActive(true);

        currentMenu = newPanel;
    }
    public void SimpleBackClbk()
    {
        ChangeTo(p20_LobbyMenu);
    }
    public void StopClientClbk()
    {
        StopClient();

        if (_isMatchmaking)
            StopMatchMaker();

        ChangeTo(p20_LobbyMenu);
    }
}
