using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodJobTween : MonoBehaviour
{
    [SerializeField] GameObject colorWheel, title, mainBox, HomeButton, ReplayButton, NextLevelButton, leftStar, MiddleStar, RightStar, textZones;
    [SerializeField] AudioSource GoodJobSound, claps;
   
    void Start()
    {
        //head1();
    }

    void Update()
    {}
    
    public void head1()
    {   
        
        LeanTween.rotateAround(colorWheel,Vector3.forward, -360,0.5f).setDelay(.1f).setLoopClamp();
        LeanTween.scale(title,new Vector3(2.03236f,1.288673f,1f),1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic); 
        LeanTween.moveLocal(title, new Vector3(0f,128f,0f),1f).setDelay(0.6f).setEase(LeanTweenType.easeInOutCubic); 
        LeanTween.scale(title, new Vector3(1.816955f,1.15182f,1f),0.5f).setDelay(0.3f).setEase(LeanTweenType.easeInOutCubic).setOnComplete(goodJob1);
    }

    public  void goodJob1()
    {  
        GoodJobSound.Play();
        LeanTween.moveLocal(mainBox,new Vector3(0f,-22f,0f),0.5f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(HomeButton,new Vector3(0.8f,0.8f,1f),0.5f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(ReplayButton,new Vector3(0.8f,0.8f,1f),0.5f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(NextLevelButton,new Vector3(1f,0.8f,1f),0.5f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(starsss1);

    }
    public void starsss1()
    {
      //starSound.Play();
      LeanTween.scale(leftStar, new Vector3(0.8f,0.8f,1f),1f).setEase(LeanTweenType.easeOutElastic);

      //starSound.Play();
      LeanTween.scale(MiddleStar, new Vector3(0.9f,0.9f,1f),1f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);

      //starSound.Play();
      LeanTween.scale(RightStar, new Vector3(0.8f,0.8f,1f),1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);

      LeanTween.scale(textZones, new Vector3(1.794375f,0.7978125f,1f),3f).setDelay(0f).setEase(LeanTweenType.easeOutElastic).setOnComplete(startClaps);
      

    }
public void startClaps()
{
    claps.Play();
}

}
