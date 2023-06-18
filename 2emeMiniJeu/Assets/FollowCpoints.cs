using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowCpoints : MonoBehaviour
{
    [SerializeField] GameObject point1,point2,point3,point4;
    [SerializeField] GameObject b1,b2,b3,b4;
    [SerializeField] GameObject y1,y2,y3,y4;

    [SerializeField] GameObject Line1,Line2,Line3;
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
    {LeanTween.scale(point1,new Vector3(0.040506f,0.04802237f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void point1click()
     {
         LeanTween.scale(point2,new Vector3(0.040506f,0.04802237f,0f),0.5f).setDelay(0.5f);
     }
     public void point2click()
     {  
        LeanTween.scale(Line1,new Vector3(0.0206881f,0.1347601f,0f),0.5f).setDelay(0f);
        LeanTween.scale(point3,new Vector3(0.040506f,0.05942769f,0.5f),0.5f).setDelay(0.5f);
     }
     public void point3click()
     {   LeanTween.scale(Line2,new Vector3(0.02589758f,0.1254803f,0f),0.5f).setDelay(0f);
         LeanTween.scale(point4,new Vector3(0.040506f,0.05942769f,0f),0.5f).setDelay(0.5f);
     }
     public void point4click()
     {
       LeanTween.scale(Line3,new Vector3(0.0206881f,0.1347601f,0f),0.5f).setDelay(0f);
     }
    
     
     public void RemoveAll()
     {
        LeanTween.scale(point1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point4,new Vector3(0f,0f,0f),0f);
    
         LeanTween.scale(Line1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line3,new Vector3(0f,0f,0f),0f);
        
     }


/****************************************************************************************/

      public void BlueColor()
     {LeanTween.scale(b1,new Vector3(0.04000734f,0.06449608f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void bpoint1click()
     {
         LeanTween.scale(b2,new Vector3(0.04050569f,0.0630322f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint2click()
     {  
        LeanTween.scale(bl1,new Vector3(0.02767344f,0.134762f,0f),0.5f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.03542106f,0.08378338f,0.5f),0.5f).setDelay(0.5f);
     }
     public void bpoint3click()
     {   LeanTween.scale(bl2,new Vector3(0.0258981f,0.2018276f,0f),0.5f).setDelay(0f);
         LeanTween.scale(b4,new Vector3(0.03848897f,0.08207813f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint4click()
     {
       LeanTween.scale(bl3,new Vector3(0.02560221f,0.1280188f,0f),0.5f).setDelay(0f);
     }
    
     
     public void bRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
    
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
        
     }



   
    /**********************************************************************************/
    public void YellowColor()
 {LeanTween.scale(y1,new Vector3(0.04000734f,0.06449608f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void ypoint1click()
     {
         LeanTween.scale(y2,new Vector3(0.04050569f,0.0630322f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint2click()
     {  
        LeanTween.scale(yl1,new Vector3(0.02767344f,0.134762f,0f),0.5f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.03542106f,0.08378338f,0.5f),0.5f).setDelay(0.5f);
     }
     public void ypoint3click()
     {   LeanTween.scale(yl2,new Vector3(0.0258981f,0.2018276f,0f),0.5f).setDelay(0f);
         LeanTween.scale(y4,new Vector3(0.03848897f,0.08207813f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint4click()
     {
       LeanTween.scale(yl3,new Vector3(0.02560221f,0.1280188f,0f),0.5f).setDelay(0f);
     }
    
     
     public void yRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
    
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
        
     }
}
