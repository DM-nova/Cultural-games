using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7,p8;
        [SerializeField] GameObject l1,l2,l3,l4;

         [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b7,b8;
        [SerializeField] GameObject bl1,bl2,bl3,bl4;

         [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y7,y8,y9;
        [SerializeField] GameObject yl1,yl2,yl3,yl4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BRedColor()
    {
        LeanTween.scale(p1,new Vector3(0.03319912f,0.05257596f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.03111328f,0.0529375f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.183f,0.04478907f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.03072437f,0.07052267f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
       LeanTween.scale(p4,new Vector3(0.0326262f,0.08799343f,0f),0.5f).setDelay(0.5f);

    }
    public void p4click()
    {
       LeanTween.scale(l2,new Vector3(0.1898625f,0.04478907f,0f),0f).setDelay(0f);
       LeanTween.scale(p5,new Vector3(0.03319912f,0.05257596f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);

    }
     
     public void p5click()
    {
          LeanTween.scale(p6,new Vector3(0.03111328f,0.0529375f,0f),0f).setDelay(0f);
    }
    public void p6click()
    {  
        LeanTween.scale(l3,new Vector3(0.183f,0.04478907f,0f),0f).setDelay(0f);
        LeanTween.scale(p7,new Vector3(0.03072437f,0.07052267f,0f),0.5f).setDelay(0.5f);

    }
    public void p7click()
    {
       LeanTween.scale(p8,new Vector3(0.0326262f,0.08799343f,0f),0.5f).setDelay(0.5f);

    }
    public void p8click()
    {
       LeanTween.scale(l4,new Vector3(0.1898625f,0.04478907f,0f),0f).setDelay(0f);

    }
    
    
    
     public void rrRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
         }

     /************************************************************************************/
      public void BblueColor()
   {
        LeanTween.scale(b1,new Vector3(0.03319912f,0.05257596f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03111328f,0.0529375f,0f),0f).setDelay(0f);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.183f,0.04478907f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.03072437f,0.07052267f,0f),0.5f).setDelay(0.5f);

    }
    public void b3click()
    {
       LeanTween.scale(b4,new Vector3(0.0326262f,0.08799343f,0f),0.5f).setDelay(0.5f);

    }
    public void b4click()
    {
       LeanTween.scale(bl2,new Vector3(0.1898625f,0.04478907f,0f),0f).setDelay(0f);

    }
    
    
     public void BRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b7,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b8,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         }
     /*******************************************************************/
          public void yellowColor()
   {
        LeanTween.scale(y1,new Vector3(0.03319912f,0.05257596f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03111328f,0.0529375f,0f),0f).setDelay(0f);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.183f,0.04478907f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.03072437f,0.07052267f,0f),0.5f).setDelay(0.5f);

    }
    public void y3click()
    {
       LeanTween.scale(y4,new Vector3(0.0326262f,0.08799343f,0f),0.5f).setDelay(0.5f);

    }
    public void y4click()
    {
       LeanTween.scale(yl2,new Vector3(0.1898625f,0.04478907f,0f),0f).setDelay(0f);

    }
    
    
     public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         }
}
