using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayScript : MonoBehaviour
{
    [SerializeField] GameObject clickToStart;
    [SerializeField] GameSetting gameSettingScript;

    [SerializeField] Animator animatorBalloonBG;
    [SerializeField] Animator animatorClickToPlayBalloon;

    void Start()
    {
        animatorBalloonBG.SetInteger("BalloonBG", 1);
        gameSettingScript = FindObjectOfType<GameSetting>().GetComponent<GameSetting>();
    }

    public void ClickToStart()
    {
        animatorClickToPlayBalloon.SetTrigger("CTSB");
        StartCoroutine(ClickToStartBalloon());
    }

    IEnumerator ClickToStartBalloon()
    {
        yield return new WaitForSeconds(0.5f);

        clickToStart.SetActive(false);
        gameSettingScript.activatePythonScript = true;
    }
         
    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
