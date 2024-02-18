using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    [SerializeField] Animator animatorStartB;
    [SerializeField] Animator animatorLeaderboardB;
    [SerializeField] Animator animatorBalloonBG;

    [SerializeField] GameObject LeaderboardPanel;

    PlayFabManager playfabManager;

    private void Start()
    {
        playfabManager = GetComponent<PlayFabManager>();
    }

    //Start New Game
    public void StartB(int value)
    {
        animatorStartB.SetInteger("SB",value);
        if (value == 4)
        {
            StartCoroutine(LevelChange());
        }
    }
    IEnumerator LevelChange()
    {
        animatorBalloonBG.SetInteger("BalloonBG", 2);
        Score.pop = 0;

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(1);
    }

    //Open Leaderboard
    public void LeaderboardB(int value)
    {
        animatorLeaderboardB.SetInteger("LBB",value);

        if (value == 4)
        {
            LeaderboardPanel.SetActive(true);
        }
    }

    //Close Leaderboard
    public void LeaderboardPaneDeactivate()
    {
        LeaderboardPanel.SetActive(false);
    }
}
