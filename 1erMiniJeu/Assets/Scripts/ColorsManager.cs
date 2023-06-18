using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;
using Unity.Services.Analytics;
using System.Collections.Generic;
using UnityEngine.Analytics;

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

     bool isDone = false;
     
     

    void Start()
    {  
        other= GameObject.FindObjectOfType<detection>();
        GoodJobTween = GameObject.FindObjectOfType<GoodJobTween>();
        GameOverTween = GameObject.FindObjectOfType<GameOverTween>();
        ScorePerSecond = GameObject.FindObjectOfType<ScorePerSecond>();
       // StartCoroutine("FixedColorsAnimation");
        SpawnerAnimation();
        ColorSpawn();

    }
    

    void Update(){

        if(colorsToSpawn.Count == 0 &&  (!isDone) )
        {
            GoodJobTween.head1();
            isDone = true;
          
        }
       scoreAmount = (int)ScorePerSecond.scoreAmount;
        if(scoreAmount == 0  &&  (!isDone))
        {   StartCoroutine("destroyFixedColors");
            GameOverTween.head2();
            isDone = true;
         
          
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
             LeanTween.scale(c,new Vector3(11f,11f,1f),0f)/*.setDelay(.8f)*/.setEase(LeanTweenType.easeOutBounce);
             pop.Play();
             yield return new WaitForSeconds(0.0000001f);
            }
    }
IEnumerator destroyFixedColors()
    {
        foreach(var c in FixedColors)
           { 
               Destroy(c);
               yield return new WaitForSeconds(0f);
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
        


    
    
