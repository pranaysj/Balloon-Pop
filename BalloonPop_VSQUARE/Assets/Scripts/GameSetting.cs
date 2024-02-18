using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting.Python;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    [SerializeField] string pythonFilePath;

    [SerializeField] Ballons ballonPrefab;
    [SerializeField] Canon canon;
    [SerializeField] Score score;

    public bool activatePythonScript;

    void Update()
    {
        
        if (activatePythonScript)
        {
            PythonRunner.RunFile(pythonFilePath);
        }
    }

    public void BalloonSpeed(float val)
    {
        ballonPrefab.ballonSpeed = val;
    }

    public void BalloonSpawnSpeed(float val)
    {
        canon.ballonSpwanSpeed = val;
    }
    public void BalloonSpawnRate(int val)
    {
        canon.ballonSpawnRate = val;
    }

    public void AllowEscapeBallon(int val)
    {
        score.allowEscape = val;
    }
}
