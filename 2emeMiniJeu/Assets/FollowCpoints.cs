using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowCpoints : MonoBehaviour
{
   // public List<GameObject> Points=new List<GameObject>();
   // public List<GameObject> Lines=new List<GameObject>();
    [SerializeField] GameObject point1,point2,point3,point4,point5,point6;
    [SerializeField] GameObject blue1,blue2,blue3,blue4,blue5,blue6;
    [SerializeField] GameObject yellow1,yellow2,yellow3,yellow4,yellow5,yellow6;

    [SerializeField] GameObject Line1,Line2,Line3,Line4;
    [SerializeField] GameObject blueLine1,blueLine2,blueLine3,blueLine4;
    [SerializeField] GameObject yellowLine1,yellowLine2,yellowLine3, yellowLine4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RedColor()
    {
        
        LeanTween.scale(point1,new Vector3(0.05378694f,0.08532178f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void point1click()
     {
           LeanTween.scale(point2,new Vector3(0.05024099f,0.08818805f,0f),0.5f).setDelay(0.5f);
     }
     public void point2click()
     {  LeanTween.scale(Line1,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);
      LeanTween.scale(point3,new Vector3(0.04908058f,0.1077187f,0.5f),0.5f).setDelay(0.5f);
        
        
        

     }
     public void point3click()
     {   LeanTween.scale(Line2,new Vector3(0.033422f,0.1961498f,0f),0.5f).setDelay(0f);
         LeanTween.scale(point4,new Vector3(0.05378694f,0.1079854f,0f),0.5f).setDelay(0.5f);
     }
     public void point4click()
     {
        
        LeanTween.scale(Line3,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);

     }
     public void point5click()
     {
         LeanTween.scale(Line3,new Vector3(0.08416407f,0.026625f,0f),0f).setDelay(2f);
     }
     public void point6click()
     {
        LeanTween.scale(Line4,new Vector3(0.07364355f,0.026625f,0f),0f).setDelay(2f);
     }
     
     public void RemoveAll()
     {
        LeanTween.scale(point1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(point6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line4,new Vector3(0f,0f,0f),0f);
     }


/****************************************************************************************/

      public void BlueColor()
    {
       
        LeanTween.scale(blue1,new Vector3(0.05378694f,0.08532178f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void bpoint1click()
     {
           LeanTween.scale(blue2,new Vector3(0.05024099f,0.08818805f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint2click()
     {  LeanTween.scale(blueLine1,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);
      LeanTween.scale(blue3,new Vector3(0.04908058f,0.1077187f,0.5f),0.5f).setDelay(0.5f);
        
        
        

     }
     public void bpoint3click()
     {   LeanTween.scale(blueLine2,new Vector3(0.033422f,0.1961498f,0f),0.5f).setDelay(0f);
         LeanTween.scale(blue4,new Vector3(0.05378694f,0.1079854f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint4click()
     {
        
        LeanTween.scale(blueLine3,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);

     }
     
     
     public void bRemoveAll()
     {
        LeanTween.scale(blue1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blue2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blue3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blue4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blue5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blue6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blueLine1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blueLine2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blueLine3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(blueLine4,new Vector3(0f,0f,0f),0f);
     }


    /**********************************************************************************/
    public void YellowColor()
    {     LeanTween.scale(yellow1,new Vector3(0.05378694f,0.08532178f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void ypoint1click()
     {
           LeanTween.scale(yellow2,new Vector3(0.05024099f,0.08818805f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint2click()
     {  LeanTween.scale(yellowLine1,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);
      LeanTween.scale(yellow3,new Vector3(0.04908058f,0.1077187f,0.5f),0.5f).setDelay(0.5f);
        
        
        

     }
     public void ypoint3click()
     {   LeanTween.scale(yellowLine2,new Vector3(0.033422f,0.1961498f,0f),0.5f).setDelay(0f);
         LeanTween.scale(yellow4,new Vector3(0.05378694f,0.1079854f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint4click()
     {
        
        LeanTween.scale(yellowLine3,new Vector3(0.033422f,0.1663427f,0f),0.5f).setDelay(0f);

     }
     
     
     public void yRemoveAll()
     {
        LeanTween.scale(yellow1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellow2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellow3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellow4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellow5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellow6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellowLine1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellowLine2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellowLine3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yellowLine4,new Vector3(0f,0f,0f),0f);
     }


}
