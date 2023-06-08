using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowFpoints : MonoBehaviour
{
   
    [SerializeField] GameObject p1,p2,p3,p4,p5;
    [SerializeField] GameObject b1,b2,b3,b4,b5;
    [SerializeField] GameObject y1,y2,y3,y4,y5;

    [SerializeField] GameObject l1,l2,l3;
    [SerializeField] GameObject bl1,bl2,bl3;
    [SerializeField] GameObject yl1,yl2,yl3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RedColor()
    {    LeanTween.scale(p1,new Vector3(0.03719594f,0.05547869f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void point1click()
     {
           LeanTween.scale(p2,new Vector3(0.04074851f,0.06077744f,0f),1f).setDelay(0f);
     }
     public void point2click()
     {  LeanTween.scale(l1,new Vector3(0.05271152f,0.02601552f,0f),0f).setDelay(2f);
      LeanTween.scale(p3,new Vector3(0.03784113f,0.06801864f,0f),1f).setDelay(0f);
        
        
        

     }
     public void point3click()
     {   LeanTween.scale(l2,new Vector3(0.133493f,0.02601552f,0f),0f).setDelay(2f);
         LeanTween.scale(p4,new Vector3(0.0373407f,0.07427852f,0f),1f).setDelay(0f);
     }
     public void point4click()
     {
        LeanTween.scale(p5,new Vector3(0.03494254f,0.07548814f,0f),0.5f).setDelay(0.5f);

     }
     public void point5click()
     {  LeanTween.scale(l3,new Vector3(0.05348669f,0.02601552f,0f),0f).setDelay(2f);
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
         
     }


/****************************************************************************************/

      public void BlueColor()
 {   
     LeanTween.scale(b1,new Vector3(0.03719594f,0.05547869f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
 }
     public void bpoint1click()
     {
           LeanTween.scale(b2,new Vector3(0.04074851f,0.06077744f,0f),1f).setDelay(0f);
     }
     public void bpoint2click()
     {  LeanTween.scale(bl1,new Vector3(0.07166295f,0.02601552f,0f),0f).setDelay(2f);
      LeanTween.scale(b3,new Vector3(0.03784113f,0.06801864f,0f),1f).setDelay(0f);
        
        
        

     }
     public void bpoint3click()
     {   LeanTween.scale(bl2,new Vector3(0.133493f,0.02601552f,0f),0f).setDelay(2f);
         LeanTween.scale(b4,new Vector3(0.0373407f,0.07427852f,0f),1f).setDelay(0f);
     }
     public void bpoint4click()
     {
        LeanTween.scale(b5,new Vector3(0.03494254f,0.07548814f,0f),0.5f).setDelay(0.5f);

     }
     public void bpoint5click()
     {  LeanTween.scale(bl3,new Vector3(0.07020128f,0.02601552f,0f),0f).setDelay(2f);
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
         
     }

    /**********************************************************************************/
    public void YellowColor()
           {   
     LeanTween.scale(y1,new Vector3(0.03719594f,0.05547869f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
 }
     public void ypoint1click()
     {
           LeanTween.scale(y2,new Vector3(0.04074851f,0.06077744f,0f),1f).setDelay(0f);
     }
     public void ypoint2click()
     {  LeanTween.scale(yl1,new Vector3(0.07166295f,0.02601552f,0f),0f).setDelay(2f);
      LeanTween.scale(y3,new Vector3(0.03784113f,0.06801864f,0f),1f).setDelay(0f);
        
        
        

     }
     public void ypoint3click()
     {   LeanTween.scale(yl2,new Vector3(0.133493f,0.02601552f,0f),0f).setDelay(2f);
         LeanTween.scale(y4,new Vector3(0.0373407f,0.07427852f,0f),1f).setDelay(0f);
     }
     public void ypoint4click()
     {
        LeanTween.scale(y5,new Vector3(0.03494254f,0.07548814f,0f),0.5f).setDelay(0.5f);

     }
     public void ypoint5click()
     {  LeanTween.scale(yl3,new Vector3(0.07020128f,0.02601552f,0f),0f).setDelay(2f);
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
         
     }
}
