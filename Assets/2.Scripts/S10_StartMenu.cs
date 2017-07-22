using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class S10_StartMenu : NetworkBehaviour
{
    // FIXME :
    public S00_LobbyManager s00_LobbyManager;

    public void OnClickStart()
    {
        // FIXME : 
        s00_LobbyManager.StartMatchMaker();
        SceneManager.LoadScene("");
    }
}