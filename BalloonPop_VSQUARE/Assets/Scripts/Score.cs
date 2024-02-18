using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] public static int pop;
    [SerializeField] public int escape;
    [SerializeField] public int allowEscape;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI escapeText;

    [SerializeField] Animator animatorCircleTransition;

    void Update()
    {
        scoreText.text = pop.ToString();
        escapeText.text = escape.ToString() + "/" + allowEscape;

        if (escape == allowEscape)
        {
            StartCoroutine(GameOverIEnum());
        }
    }

    IEnumerator GameOverIEnum()
    {
        animatorCircleTransition.SetTrigger("CircleOutForGamePlay");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }
}
