using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingHands : MonoBehaviour
{
    [SerializeField] GameObject hands ;
    [SerializeField] GameObject Ball ;
    [SerializeField] GameObject  MenuBox, choose, colorsButton, startButtonColors, lettersButton, startButtonLetters,colorWheel, ColorsLevelsBOX,LettersLevelsBOX;
    [SerializeField] AudioSource titleShowUp, boxSlide,bg;

    void Start()
    {  
        StartCoroutine("moveHands");
       
    }
    void Update()
    {}
    
    public void welcomeCo()
    {
        StartCoroutine("welcomeSound");
    }
    IEnumerator welcomeSound()
    {
        bg.Pause();
        yield return new WaitForSeconds(10f);
        bg.Play();
            
    }
    public void ColorsLevels()
    {
        LeanTween.scale(ColorsLevelsBOX,new Vector3(2.123125f,1f,0f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
    public void LettersLevels()
    {
        LeanTween.scale(LettersLevelsBOX,new Vector3(2.123125f,1f,0f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
    
    public void Choose()
    {   
        LeanTween.rotateAround(colorWheel,Vector3.forward, -360,5f).setDelay(.5f).setLoopClamp();
        LeanTween.scale(choose,new Vector3(0.5f,0.5f,1f),1f).setDelay(0.3f).setEase(LeanTweenType.easeOutElastic); 
        LeanTween.moveLocal(choose, new Vector3(-2.9005f,153.01f,0f),1f).setDelay(0.6f).setEase(LeanTweenType.easeInOutCubic); 
        LeanTween.scale(choose, new Vector3(0.3211021f,0.369151f,0f),0.5f).setDelay(0.9f).setEase(LeanTweenType.easeInOutCubic).setOnComplete(mainBox);
    }

    public  void mainBox()
    {   
        //boxSlide.Play();
        LeanTween.moveLocal(MenuBox,new Vector3(-4f,-15.21f,0f),0.5f).setDelay(0f);
        LeanTween.scale(colorsButton,new Vector3(0.2541003f,0.2541003f,0f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(startButtonColors,new Vector3(0.1131362f,0.1131362f,1f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
        
        LeanTween.scale(lettersButton,new Vector3(0.2541003f,0.2541003f,1f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(startButtonLetters,new Vector3(0.1131362f,0.1131362f,1f),1f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }

    public void removeHands()
    {
        LeanTween.scale(hands,new Vector3(0f,0f,0f),0f).setDelay(0.1f).setEase(LeanTweenType.easeInOutCubic).setOnComplete(Choose);
    }

    IEnumerator moveHands()
    {
        while(true)
        {
            LeanTween.rotateAround(hands,new Vector3(0,0,21.6164f)/*.forward*/, -30,1f).setDelay(0f);
            LeanTween.moveLocal(Ball,new Vector3(45f,22.3f),10f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
            yield return new WaitForSeconds(1);
  
            LeanTween.rotateAround(hands,new Vector3(0,0,21.6164f), 30,1f).setDelay(0f);
            yield return new WaitForSeconds(1);

            LeanTween.rotateAround(hands,new Vector3(0,0,21.6164f), 30,1f).setDelay(0f);
            LeanTween.moveLocal(Ball,new Vector3(-50f,22.3f),10f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
            yield return new WaitForSeconds(1);

            LeanTween.rotateAround(hands,new Vector3(0,0,21.6164f)/*.forward*/, -30,1f).setDelay(0f);
            yield return new WaitForSeconds(1);
        }
    }
}
