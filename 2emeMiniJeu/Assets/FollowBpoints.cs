using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7,p8,p9;
        [SerializeField] GameObject l1,l2,l3,l4,l5,l6,l7;

         [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b7,b8,b9;
        [SerializeField] GameObject bl1,bl2,bl3,bl4,bl5,bl6,bl7;

         [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y7,y8,y9;
        [SerializeField] GameObject yl1,yl2,yl3,yl4,yl5,yl6,yl7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BRedColor()
    {
        LeanTween.scale(p1,new Vector3(0.04226179f,0.0659507f,0.5f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.04226179f,0.0659507f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.13125f,1.015004f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
        LeanTween.scale(l2,new Vector3(0.108752f,0.4730721f,0f),0f).setDelay(0f);
        LeanTween.scale(p4,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {
        LeanTween.scale(l3,new Vector3(0.2100811f,0.5034416f,0f),0.2f).setDelay(0f);
        LeanTween.scale(p5,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p5click()
    {
        
        LeanTween.scale(l4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(p6,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
        
    }
      public void p6click()
    {   
        LeanTween.scale(l4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(p7,new Vector3(0.04642722f,0.08575137f,0f),0.5f).setDelay(0.5f);
        
    }
      public void p7click()
    {
        //LeanTween.scale(l5,new Vector3(0.1141225f,0.5699928f,0f),0f).setDelay(0f);
        LeanTween.scale(p8,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);
    }
    public void p8click()
    {
        LeanTween.scale(l6,new Vector3(0.2100811f,0.6343364f,0f),0f).setDelay(0f);
        LeanTween.scale(p9,new Vector3(0.04226179f,0.07617306f,0f),0.5f).setDelay(0.5f);
        //LeanTween.scale(p2,new Vector3(0f,0f,0f),0f).setDelay(0f);
    }
    public void p9click()
    {
        
        LeanTween.scale(l7,new Vector3(0.1141225f,0.603167f,0f),0f).setDelay(0f);
    }
     public void rrBRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p7,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l7,new Vector3(0f,0f,0f),0f);
     }

     /************************************************************************************/
      public void BblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.04226179f,0.0659507f,0.5f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.04226179f,0.0659507f,0f),0f).setDelay(0f);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.13125f,1.015004f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);

    }
    public void b3click()
    {
        LeanTween.scale(bl2,new Vector3(0.108752f,0.4730721f,0f),0f).setDelay(0f);
        LeanTween.scale(b4,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {
        LeanTween.scale(bl3,new Vector3(0.2100811f,0.5034416f,0f),0.2f).setDelay(0f);
        LeanTween.scale(b5,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b5click()
    {
        
        LeanTween.scale(bl4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(b6,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
        
    }
      public void b6click()
    {   
        LeanTween.scale(bl4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(b7,new Vector3(0.04642722f,0.08575137f,0f),0.5f).setDelay(0.5f);
        
    }
      public void b7click()
    {
        //LeanTween.scale(l5,new Vector3(0.1141225f,0.5699928f,0f),0f).setDelay(0f);
        LeanTween.scale(b8,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);
    }
    public void b8click()
    {
        LeanTween.scale(bl6,new Vector3(0.2100811f,0.6343364f,0f),0f).setDelay(0f);
        LeanTween.scale(b9,new Vector3(0.04226179f,0.07617306f,0f),0.5f).setDelay(0.5f);
        //LeanTween.scale(p2,new Vector3(0f,0f,0f),0f).setDelay(0f);
    }
    public void b9click()
    {
        
        LeanTween.scale(bl7,new Vector3(0.1141225f,0.603167f,0f),0f).setDelay(0f);
    }
     public void bbBRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b7,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl7,new Vector3(0f,0f,0f),0f);
     }
     /*******************************************************************/
          public void ByellowColor()
    {
        LeanTween.scale(y1,new Vector3(0.04226179f,0.0659507f,0.5f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.04226179f,0.0659507f,0f),0f).setDelay(0f);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.13125f,1.015004f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);

    }
    public void y3click()
    {
        LeanTween.scale(yl2,new Vector3(0.108752f,0.4730721f,0f),0f).setDelay(0f);
        LeanTween.scale(y4,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {
        LeanTween.scale(yl3,new Vector3(0.2100811f,0.5034416f,0f),0.2f).setDelay(0f);
        LeanTween.scale(y5,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y5click()
    {
        
        LeanTween.scale(yl4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(y6,new Vector3(0.04226179f,0.08070717f,0f),0.5f).setDelay(0.5f);
        
    }
      public void y6click()
    {   
        LeanTween.scale(yl4,new Vector3(0.1074094f,0.4354111f,0f),0f).setDelay(0f);
        //LeanTween.scale(p4,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(y7,new Vector3(0.04642722f,0.08575137f,0f),0.5f).setDelay(0.5f);
        
    }
      public void y7click()
    {
        //LeanTween.scale(l5,new Vector3(0.1141225f,0.5699928f,0f),0f).setDelay(0f);
        LeanTween.scale(y8,new Vector3(0.04156997f,0.08189442f,0f),0.5f).setDelay(0.5f);
    }
    public void y8click()
    {
        LeanTween.scale(yl6,new Vector3(0.2100811f,0.6343364f,0f),0f).setDelay(0f);
        LeanTween.scale(y9,new Vector3(0.04226179f,0.07617306f,0f),0.5f).setDelay(0.5f);
        //LeanTween.scale(p2,new Vector3(0f,0f,0f),0f).setDelay(0f);
    }
    public void y9click()
    {
        
        LeanTween.scale(yl7,new Vector3(0.1141225f,0.603167f,0f),0f).setDelay(0f);
    }
     public void yyBRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y7,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl7,new Vector3(0f,0f,0f),0f);
     }


}
