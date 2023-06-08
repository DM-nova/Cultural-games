using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5,p6;
        [SerializeField] GameObject l1,l2,l3;

         [SerializeField] GameObject b1,b2,b3,b4,b5,b6;
        [SerializeField] GameObject bl1,bl2,bl3;

         [SerializeField] GameObject y1,y2,y3,y4,y5,y6;
        [SerializeField] GameObject yl1,yl2,yl3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BRedColor()
    {
        LeanTween.scale(p1,new Vector3(0.035625f,0.05493544f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.035625f,0.05f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.1814063f,0.04375f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.03273449f,0.06468187f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
        LeanTween.scale(p4,new Vector3(0.032734499f,0.06321183f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {
        LeanTween.scale(l2,new Vector3(0.1814063f,0.04375f,0f),0.2f).setDelay(0f);
        LeanTween.scale(p5,new Vector3(0.03446942f,0.07120591f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
        LeanTween.scale(p6,new Vector3(0.03556521f,0.06820323f,0f),0.5f).setDelay(0.5f);
    }
    public void p6click()
    {
        LeanTween.scale(l3,new Vector3(0.1006946f,0.04375f,0f),0.2f).setDelay(0f);
    }
     public void rrBRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);}

     /************************************************************************************/
      public void BblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.035625f,0.05493544f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.035625f,0.05f,0f),0f).setDelay(0f);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.1814063f,0.04375f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.03273449f,0.06468187f,0f),0.5f).setDelay(0.5f);

    }
    public void b3click()
    {
        LeanTween.scale(b4,new Vector3(0.032734499f,0.06321183f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {
        LeanTween.scale(bl2,new Vector3(0.1814063f,0.04375f,0f),0.2f).setDelay(0f);
        LeanTween.scale(b5,new Vector3(0.03446942f,0.07120591f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
        LeanTween.scale(b6,new Vector3(0.03556521f,0.06820323f,0f),0.5f).setDelay(0.5f);
    }
    public void b6click()
    {
        LeanTween.scale(bl3,new Vector3(0.1006946f,0.04375f,0f),0.2f).setDelay(0f);
    }
     public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);}
     /*******************************************************************/
          public void ByellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.035625f,0.05493544f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.035625f,0.05f,0f),0f).setDelay(0f);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.1814063f,0.04375f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.03273449f,0.06468187f,0f),0.5f).setDelay(0.5f);

    }
    public void y3click()
    {
        LeanTween.scale(y4,new Vector3(0.032734499f,0.06321183f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {
        LeanTween.scale(yl2,new Vector3(0.1814063f,0.04375f,0f),0.2f).setDelay(0f);
        LeanTween.scale(y5,new Vector3(0.03446942f,0.07120591f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {
        LeanTween.scale(y6,new Vector3(0.03556521f,0.06820323f,0f),0.5f).setDelay(0.5f);
    }
    public void y6click()
    {
        LeanTween.scale(yl3,new Vector3(0.1006946f,0.04375f,0f),0.2f).setDelay(0f);
    }
     public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);}
}