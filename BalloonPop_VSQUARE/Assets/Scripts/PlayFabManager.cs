using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.MultiplayerModels;
using UnityEditor.Tilemaps;
using UnityEngine.UI;
using TMPro;

public class PlayFabManager : MonoBehaviour
{
    [SerializeField] GameObject rowPrefab;
    [SerializeField] Transform rowParent;

    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    //LOGIN
    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };

        PlayFabClientAPI.LoginWithCustomID(request, Success, Error);
    }

    void Success(LoginResult result)
    {
        Debug.Log("Login successful.");
    }

    //ERROR
    void Error(PlayFabError error)
    {
        Debug.Log("Sorry error");
        Debug.Log(error.GenerateErrorReport());
    }

    //SENDDATA
    public void SendLeaderbosrd(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "BalloonPopScore",
                    Value = score
                }
            }
        };

        PlayFabClientAPI.UpdatePlayerStatistics(request, SubmitScoore, Error);
    }

    void SubmitScoore(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Submit Successful");
    }

    //GETDATA
    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "BalloonPopScore",
            StartPosition = 0,
            MaxResultsCount = 20,
        };
        
        PlayFabClientAPI.GetLeaderboard(request, GetLeaderB, Error);
    }

    void GetLeaderB(GetLeaderboardResult result)
    {
        foreach (Transform item in rowParent)
        {
            Destroy(item.gameObject);
        }
        
        foreach (var item in result.Leaderboard)
        {
            GameObject rowspawn = Instantiate(rowPrefab,rowParent);
            TextMeshProUGUI[] text = rowspawn.GetComponentsInChildren<TextMeshProUGUI>();
            text[0].text = (item.Position.ToString() + 1);
            text[1].text = item.PlayFabId;
            text[2].text = item.StatValue.ToString();


            Debug.Log(item.Position + " " + item.PlayFabId + " " + item.StatValue);
        }
    }
}
