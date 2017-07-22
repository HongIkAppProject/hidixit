using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S40_RoomSetting : MonoBehaviour
{
    public S00_LobbyManager s00_LobbyManager;
    //public RectTransform p20_LobbyMenu;
    public InputField p42_RoomNameInput;

    void OnEnable()
    {
        p42_RoomNameInput.onEndEdit.RemoveAllListeners();
        p42_RoomNameInput.onEndEdit.AddListener(onEndEditGameName);
    }

    void onEndEditGameName(string Text)
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            OnClickCreateGame();
        }
    }
    
    public void OnClickCreateGame()
    {
        s00_LobbyManager.StartMatchMaker();
        s00_LobbyManager.matchMaker.CreateMatch(
            p42_RoomNameInput.text,
            (uint)s00_LobbyManager.maxPlayers,
            true,
            "", "", "", 0, 0,
            s00_LobbyManager.OnMatchCreate);

        s00_LobbyManager.backDelegate = s00_LobbyManager.StopHost;
        s00_LobbyManager._isMatchmaking = true;
        //lobbyManager.DisplayConnecting();


    }
}
