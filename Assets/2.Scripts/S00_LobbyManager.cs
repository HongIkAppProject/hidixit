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
