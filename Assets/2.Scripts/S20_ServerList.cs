using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;
using UnityEngine.SceneManagement;

public class S20_ServerList : MonoBehaviour
{
    public S00_LobbyManager s00_LobbyManager;
    public RectTransform p23_ServerList;
    public GameObject p24_ServerEntryPrefab;
    public GameObject p25_NoServerFound;
    public RectTransform p30_PersonalSettingMenu;
    public RectTransform p40_RoomSettingMenu;

    void OnEnable()
    {
        foreach (Transform T in p23_ServerList)
            Destroy(T.gameObject);
        p25_NoServerFound.SetActive(false);
        //RequestPage(0);
    }

    public void OnClickOption()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void OnClickCreate()
    {
        SceneManager.LoadScene("CreateScene");
    }

    public void RequestPage(int page)
    {
        //TODO 스크롤뷰 구현 후 파라미터를 6 이상으로 변경
        s00_LobbyManager.matchMaker.ListMatches(page, 6, "", true, 0, 0, OnGUImatchList);
    }

    void OnGUImatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matches)
    {
        if (matches.Count == 0)
            p25_NoServerFound.SetActive(true);
        else
        {
            p25_NoServerFound.SetActive(false);
            foreach (Transform t in p23_ServerList)
                Destroy(t.gameObject);

            for (int i = 0; i < matches.Count; i++)
            {
                GameObject o = Instantiate(p24_ServerEntryPrefab) as GameObject;
                o.GetComponent<S21_ServerEntry>().Populate(matches[i], s00_LobbyManager);
                o.transform.SetParent(p23_ServerList, false);
            }
        }
    }
}
