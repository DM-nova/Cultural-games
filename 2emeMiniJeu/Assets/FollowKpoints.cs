using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowKpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5;
        [SerializeField] GameObject l1,l2,l3;

         [SerializeField] GameObject b1,b2,b3,b4,b5;
        [SerializeField] GameObject bl1,bl2,bl3;

         [SerializeField] GameObject y1,y2,y3,y4,y5;
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
        LeanTween.scale(p1,new Vector3(0.02375f,0.05f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02375f,0.05f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.1827861f,0.04213537f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.02375f,0.055625f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
        LeanTween.scale(p4,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {
        LeanTween.scale(l2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
        LeanTween.scale(p5,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
       LeanTween.scale(l3,new Vector3(0.09842275f,0.03955437f,0f),0.2f).setDelay(0f);
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
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);}

     /************************************************************************************/
      public void BblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.02375f,0.05f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02375f,0.05f,0f),0f).setDelay(0f);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.1827861f,0.04213537f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.02375f,0.055625f,0f),0.5f).setDelay(0.5f);

    }
    public void b3click()
    {
        LeanTween.scale(b4,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {
        LeanTween.scale(bl2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
        LeanTween.scale(b5,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
       LeanTween.scale(bl3,new Vector3(0.09842275f,0.03955437f,0f),0.2f).setDelay(0f);
    }
    
     public void bbBRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
        
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);}
     /*******************************************************************/
          public void ByellowColor()
    {
        LeanTween.scale(y1,new Vector3(0.02375f,0.05f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.02375f,0.05f,0f),0f).setDelay(0f);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.1827861f,0.04213537f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.02375f,0.055625f,0f),0.5f).setDelay(0.5f);

    }
    public void y3click()
    {
        LeanTween.scale(y4,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {
        LeanTween.scale(yl2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
        LeanTween.scale(y5,new Vector3(0.0260585f,0.06103175f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {
       LeanTween.scale(yl3,new Vector3(0.09842275f,0.03955437f,0f),0.2f).setDelay(0f);
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
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);}
}
