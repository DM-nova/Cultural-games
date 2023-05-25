using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsManager : MonoBehaviour
{    
     [SerializeField] GameObject Spawner;
     [SerializeField] AudioSource pop;
     public detection other;
     public List<GameObject> colorsToSpawn = new List<GameObject>();
     public List<GameObject> FixedColors = new List<GameObject>();
     public bool isRandomized;
     GoodJobTween GoodJobTween;
     GameOverTween GameOverTween;
     public Text TimeText,ScoreText;
     ScorePerSecond ScorePerSecond;
     public int scoreAmount;
     
     

    void Start()
    {  
        other= GameObject.FindObjectOfType<detection>();
        GoodJobTween = GameObject.FindObjectOfType<GoodJobTween>();
        GameOverTween = GameObject.FindObjectOfType<GameOverTween>();
        ScorePerSecond = GameObject.FindObjectOfType<ScorePerSecond>();
        StartCoroutine("FixedColorsAnimation");
        SpawnerAnimation();
        ColorSpawn();

    }

    void Update(){

        if(colorsToSpawn.Count == 0 )
        {
            GoodJobTween.head1();
        }
       scoreAmount = (int)ScorePerSecond.scoreAmount;
        if(scoreAmount == 0 )
        {
            GameOverTween.head2();
        }

    }
    public void SpawnerAnimation()
    {
        LeanTween.moveLocal(Spawner,new Vector3(0f,175f,0f),2f).setDelay(0f)/*.setEase(LeanTweenType.easeOutElastic)*/;
        LeanTween.moveLocal(Spawner,new Vector3(0f,251f,0f),2f).setDelay(0f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }

    IEnumerator FixedColorsAnimation()
    {
        foreach(var c in FixedColors)
           {  yield return new WaitForSeconds(0.1f);
             LeanTween.scale(c,new Vector3(12f,12f,1f),0f)/*.setDelay(.8f)*/.setEase(LeanTweenType.easeOutBounce);
             pop.Play();
             yield return new WaitForSeconds(0.05f);
            }
    }

    public void ColorSpawn()
    {   
        int index= isRandomized ?Random.Range(0, colorsToSpawn.Count):0;
        Instantiate(colorsToSpawn[index], transform.position, transform.rotation);
    }
    public void RemoveColor(string str) 
    {
        for (int i = 0; i < colorsToSpawn.Count; i++)
           {
             string s = colorsToSpawn[i].name + "(Clone)";
             if (s == str) 
                 {
                    colorsToSpawn.RemoveAt(i);
                    break;
                 }
           }
    }
}   
        


    
    
