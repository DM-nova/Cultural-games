//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;


public class levelEventManager : MonoBehaviour
{
   /* public enum LevelPlayState { InProgress, Won, Lost, Skip, Quit}

    private Scene thisScene;
    private LevelPlayState state = LevelPlayState.InProgress;
    private int score = 0;
    private float secondsElapsed =0;
    private int deaths = 0;

    void Awake ()
    {
        thisScene = SceneManager.GetActiveScene();
        analyticsEvent.LevelStart(thisScene.name, thisScene.buildIndex);
    }

    /*public void SetLevelPlayState(LevelPlayState newState)
    {
        this.state=newState;
    }*/

}
