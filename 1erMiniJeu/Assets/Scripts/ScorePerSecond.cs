using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{    
    IEnumerator ScoreCoroutine;
    public GoodJobTween gjtween;
    public GameOverTween gotween;
    public TimeSpentCounter startTime;
    public ColorsManager colorsToSpawn;
    public Text scoreText;
    public float scoreAmount;
    public float pointsDecreasedPerSecond;

    TimeSpentCounter TimeSpentCounter;

    [SerializeField] public GameObject FixedColors;
    [SerializeField] public GameObject ColorsManager;
    
    void Start()
    {   
        TimeSpentCounter= GameObject.FindObjectOfType<TimeSpentCounter>();

        gjtween= GameObject.FindObjectOfType<GoodJobTween>();
        gotween= GameObject.FindObjectOfType<GameOverTween>();
        colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
        startTime= GameObject.FindObjectOfType<TimeSpentCounter>();

        ScoreCoroutine = decreaseScore();
        StartCoroutine(ScoreCoroutine);
        
       // scoreAmount = 5f;
        pointsDecreasedPerSecond = 1f;
    }

    void Update()
    {}

    IEnumerator  decreaseScore()
    { 
        while ((colorsToSpawn.colorsToSpawn.Count != 0) && (scoreAmount>0))
        {
              scoreText.text =(int)scoreAmount +"";
              scoreAmount = scoreAmount - pointsDecreasedPerSecond * Time.deltaTime;
              yield return new WaitForSeconds(0);
        }
        if(colorsToSpawn.colorsToSpawn.Count == 0 )
        {
            colorsToSpawn.ScoreText.text = (int)scoreAmount +"";
        }
        if((int)scoreAmount == 0 )
        {
            //colorsToSpawn.TimeText2.text = (int)TimeSpentCounter.startTime +"";
            colorsToSpawn.tim.SetActive(false);
        }
    }

}