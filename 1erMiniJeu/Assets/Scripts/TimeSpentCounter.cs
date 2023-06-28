using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;
using Unity.Services.Analytics;
using System.Collections.Generic;
using UnityEngine.Analytics;

public class TimeSpentCounter : MonoBehaviour
{    
    IEnumerator TimeCoroutine;
    public ColorsManager colorsToSpawn;
    public Text timeText;
    public float startTime;
    public float timeIncreasedPerSecond;
   public ScorePerSecond ScorePerSecond;
    public float scoreAmount;
    DataManager DataManager;
    
    void Start()
    {  
       DataManager = FindObjectOfType<DataManager>();
        colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
        ScorePerSecond = GameObject.FindObjectOfType<ScorePerSecond>();
        TimeCoroutine = IncreaseTime();
        StartCoroutine(TimeCoroutine);
        startTime = 0f;
        timeIncreasedPerSecond = 1f;
    }
    void Update()
    {}

    IEnumerator  IncreaseTime() 
    { 
        while (colorsToSpawn.colorsToSpawn.Count != 0)
        {
            timeText.text =(int)startTime +"";
            startTime = startTime + timeIncreasedPerSecond *Time.deltaTime;
            yield return null;
        }
        if(colorsToSpawn.colorsToSpawn.Count == 0 )
        {
            colorsToSpawn.TimeText.text = (int)startTime +"";
            //DataManager.Val=1;
        }
        /* if(scoreAmount == 0 )
        {
            colorsToSpawn.TimeText2.text = (int)startTime +"";
        } */

    }

    
}