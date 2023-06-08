using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowGpoints : MonoBehaviour
{
   
    [SerializeField] GameObject p1,p2,p3,p4,p5;
    [SerializeField] GameObject b1,b2,b3,b4,b5;
    [SerializeField] GameObject y1,y2,y3,y4,y5;

    [SerializeField] GameObject l1,l2,l3,l4,l5;
    [SerializeField] GameObject bl1,bl2,bl3,bl4,bl5;
    [SerializeField] GameObject yl1,yl2,yl3, yl4,yl5;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void RedColor()
    {
      LeanTween.scale(p1,new Vector3(0.03769475f,0.06294281f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void point1click()
     {
           LeanTween.scale(p2,new Vector3(0.03686716f,0.06471621f,0f),0.5f).setDelay(0.5f);
     }
     public void point2click()
     {  LeanTween.scale(l1,new Vector3(0.03342132f,0.1663423f,0f),0.5f).setDelay(0f);
      LeanTween.scale(p3,new Vector3(0.03649934f,0.08010545f,0.5f),0.5f).setDelay(0.5f);
       
     }
     public void point3click()
     {   LeanTween.scale(l2,new Vector3(0.03253715f,0.2028808f,0f),0.5f).setDelay(0f);
         LeanTween.scale(p4,new Vector3(0.03422019f,0.06870966f,0f),0.5f).setDelay(0.5f);
     }
     public void point4click()
     {
        LeanTween.scale(l3,new Vector3(0.03342057f,0.1705022f,0f),0.5f).setDelay(0f);
        LeanTween.scale(l4,new Vector3(0.01798774f,0.03515548f,0f),0.5f).setDelay(0f);
        LeanTween.scale(p5,new Vector3(0.03422019f,0.06870966f,0f),0.5f).setDelay(0.5f);

     }
     public void point5click()
     {
         LeanTween.scale(l5,new Vector3(0.03423005f,0.02333189f,0f),0f).setDelay(2f);
     }
     
     
     public void RemoveAll()
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
         LeanTween.scale(l5,new Vector3(0f,0f,0f),0f);
     }


/****************************************************************************************/

      public void BlueColor()
    {    
      LeanTween.scale(b1,new Vector3(0.03845323f,0.07720904f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void bpoint1click()
     {
           LeanTween.scale(b2,new Vector3(0.04175574f,0.07329758f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint2click()
     {  LeanTween.scale(bl1,new Vector3(0.03991149f,0.1986447f,0f),0.5f).setDelay(0f);
      LeanTween.scale(b3,new Vector3(0.04133915f,0.09072743f,0.5f),0.5f).setDelay(0.5f);
       
     }
     public void bpoint3click()
     {   LeanTween.scale(bl2,new Vector3(0.0342216f,0.2347224f,0f),0.5f).setDelay(0f);
         LeanTween.scale(b4,new Vector3(0.03936348f,0.07903672f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint4click()
     {
        LeanTween.scale(bl3,new Vector3(0.03958424f,0.2019662f,0f),0.5f).setDelay(0f);
        LeanTween.scale(bl4,new Vector3(0.02084959f,0.04074872f,0f),0.5f).setDelay(0f);
        LeanTween.scale(b5,new Vector3(0.03845323f,0.07720904f,0f),0.5f).setDelay(0.5f);

     }
     public void bpoint5click()
     {
         LeanTween.scale(bl5,new Vector3(0.03755721f,0.02559975f,0f),0f).setDelay(2f);
     }
     
     public void bRemoveAll()
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
          LeanTween.scale(bl5,new Vector3(0f,0f,0f),0f);
     }


    /**********************************************************************************/
    public void YellowColor()
   {    
      LeanTween.scale(y1,new Vector3(0.03845323f,0.07720904f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void ypoint1click()
     {
           LeanTween.scale(y2,new Vector3(0.04175574f,0.07329758f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint2click()
     {  LeanTween.scale(yl1,new Vector3(0.03991149f,0.1986447f,0f),0.5f).setDelay(0f);
      LeanTween.scale(y3,new Vector3(0.04133915f,0.09072743f,0.5f),0.5f).setDelay(0.5f);
       
     }
     public void ypoint3click()
     {   LeanTween.scale(yl2,new Vector3(0.0342216f,0.2347224f,0f),0.5f).setDelay(0f);
         LeanTween.scale(y4,new Vector3(0.03936348f,0.07903672f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint4click()
     {
        LeanTween.scale(yl3,new Vector3(0.03958424f,0.2019662f,0f),0.5f).setDelay(0f);
        LeanTween.scale(yl4,new Vector3(0.02084959f,0.04074872f,0f),0.5f).setDelay(0f);
        LeanTween.scale(y5,new Vector3(0.03845323f,0.07720904f,0f),0.5f).setDelay(0.5f);

     }
     public void ypoint5click()
     {
         LeanTween.scale(yl5,new Vector3(0.03755721f,0.02559975f,0f),0f).setDelay(2f);
     }
     
     public void yRemoveAll()
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
         LeanTween.scale(yl5,new Vector3(0f,0f,0f),0f);
     }
}
