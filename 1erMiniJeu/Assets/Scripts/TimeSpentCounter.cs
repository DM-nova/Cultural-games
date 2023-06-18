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
    
    void Start()
    {  
        colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
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
            

        }
    }

    
}