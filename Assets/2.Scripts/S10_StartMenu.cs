using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S10_StartMenu : MonoBehaviour
{
    public S00_LobbyManager s00_LobbyManager;
    public RectTransform p20_LobbyMenu;

    public void OnClickStart()
    {
        s00_LobbyManager.StartMatchMaker();
        s00_LobbyManager.backDelegate = s00_LobbyManager.SimpleBackClbk;
        s00_LobbyManager.ChangeTo(p20_LobbyMenu);
    }
}