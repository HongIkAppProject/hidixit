using UnityEngine;
using System.Collections;
using UnityEngine.Networking.Match;
using UnityEngine.UI;
using UnityEngine.Networking.Types;

public class S21_ServerEntry : MonoBehaviour
{
    public Text serverInfoText;
    public Text slotInfo;
    public Button joinButton;
    public NetworkID networkID;
    public NodeID nodeID;

    public void Populate(MatchInfoSnapshot match, S00_LobbyManager lobbyManager)
    {
        // 방제목
        // 현재인원수 / 최대인원수
        // 네트워크 ID
        // TODO 방장 닉네임 or 방제목

        serverInfoText.text = match.name;
        slotInfo.text = match.currentSize.ToString() + "/" + match.maxSize.ToString();
        networkID = match.networkId;
        nodeID = match.hostNodeId;

        joinButton.onClick.RemoveAllListeners();
        joinButton.onClick.AddListener(() => { JoinMatch(networkID, lobbyManager); });
    }
    
    void JoinMatch(NetworkID networkID, S00_LobbyManager lobbyManager)
    {
        lobbyManager.matchMaker.JoinMatch(networkID, "", "", "", 0, 0, lobbyManager.OnMatchJoined);
        lobbyManager.backDelegate = lobbyManager.StopClientClbk;
        lobbyManager._isMatchmaking = true;
        // lobbyManager.DisplayIsConneting();
    }
}
