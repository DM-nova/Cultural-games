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

    [SerializeField] public GameObject FixedColors;
    [SerializeField] public GameObject ColorsManager;
    
    void Start()
    {   
        gjtween= GameObject.FindObjectOfType<GoodJobTween>();
        gotween= GameObject.FindObjectOfType<GameOverTween>();
        colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
        startTime= GameObject.FindObjectOfType<TimeSpentCounter>();

        ScoreCoroutine = decreaseScore();
        StartCoroutine(ScoreCoroutine);
        
        scoreAmount = 10f;
        pointsDecreasedPerSecond = 1f;
    }

    void Update()
    { }

    IEnumerator  decreaseScore()
    { 
        while (colorsToSpawn.colorsToSpawn.Count != 0)
        {
              scoreText.text =(int)scoreAmount +"";
              scoreAmount = scoreAmount - pointsDecreasedPerSecond *Time.deltaTime;
              yield return new WaitForSeconds(0);
        }

        if(colorsToSpawn.colorsToSpawn.Count == 0 )
        {
            Debug.Log("0");
        }
    }

} 

    

