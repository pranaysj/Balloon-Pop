using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    //[SerializeField] public int pop;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] Animator animatorStartB;
    [SerializeField] Animator animatorLeaderboardB;
    [SerializeField] Animator animatorSubmitB;

    [SerializeField] Animator animatorCircleTransition;

    [SerializeField] GameObject LeaderboardPanel;

    PlayFabManager playfabManager;

    private void Start()
    {
        playfabManager = GetComponent<PlayFabManager>();
    }

    void Update()
    {
        scoreText.text = Score.pop.ToString();
    }


    public void StartB(int value)
    {
        animatorStartB.SetInteger("SB", value);
        if (value == 4)
        {
            StartCoroutine(LevelChange());
        }
    }

    IEnumerator LevelChange()
    {
        animatorCircleTransition.SetInteger("CircleOut",1);

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(0);
    }

    public void SubmitB(int value)
    {
        animatorSubmitB.SetInteger("submit", value);
        if (value == 4)
        {
            playfabManager.SendLeaderbosrd(Score.pop);
        }
    }

    public void LeaderboardB(int value)
    {
        animatorLeaderboardB.SetInteger("LBB", value);

        if (value == 4)
        {
            LeaderboardPanel.SetActive(true);
        }
    }

    public void LeaderboardPaneDeactivate()
    {
        LeaderboardPanel.SetActive(false);
    }
}
