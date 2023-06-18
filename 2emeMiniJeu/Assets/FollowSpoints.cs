using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5;
        [SerializeField] GameObject l1,l2,l3,l4;

         [SerializeField] GameObject b1,b2,b3,b4,b5;
        [SerializeField] GameObject bl1,bl2,bl3,bl4;

         [SerializeField] GameObject y1,y2,y3,y4,y5;
        [SerializeField] GameObject yl1,yl2,yl3,yl4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void RedColor()
    {
        LeanTween.scale(p1,new Vector3(0.0306255f,0.05f,0.05f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.0306255f,0.05f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.03857799f,0.172717f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
    public void p3click()
    {  LeanTween.scale(l2,new Vector3(0.0460419f,0.1941785f,0f),0f).setDelay(0f);
        LeanTween.scale(p4,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
      public void p4click()
    {
         LeanTween.scale(l3,new Vector3(0.05640133f,0.2014602f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
       public void p5click()
    {
         LeanTween.scale(l4,new Vector3(0.04281156f,0.196583f,0f),0f).setDelay(0f);
    }
    
    
     public void rrBRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
            LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
             LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
            
         }

     /************************************************************************************/
      public void BblueColor()
       {
        LeanTween.scale(b1,new Vector3(0.0306255f,0.05f,0.05f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.0306255f,0.05f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.03857799f,0.172717f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
    public void b3click()
    {  LeanTween.scale(bl2,new Vector3(0.0460419f,0.1941785f,0f),0f).setDelay(0f);
        LeanTween.scale(b4,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
      public void b4click()
    {
         LeanTween.scale(bl3,new Vector3(0.05640133f,0.2014602f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
       public void b5click()
    {
         LeanTween.scale(bl4,new Vector3(0.04281156f,0.196583f,0f),0f).setDelay(0f);
    }
    
    
     public void BRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
            LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
             LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
            
         }

     /*******************************************************************/
          public void yellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.0306255f,0.05f,0.05f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.0306255f,0.05f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.03857799f,0.172717f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
    public void y3click()
    {  LeanTween.scale(yl2,new Vector3(0.0460419f,0.1941785f,0f),0f).setDelay(0f);
        LeanTween.scale(y4,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
      public void y4click()
    {
         LeanTween.scale(yl3,new Vector3(0.05640133f,0.2014602f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.0306255f,0.0675f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }
       public void y5click()
    {
         LeanTween.scale(yl4,new Vector3(0.04281156f,0.196583f,0f),0f).setDelay(0f);
    }
    
    
     public void yyBRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
            LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
             LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
            
         }

}
