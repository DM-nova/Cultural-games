using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowEpoints : MonoBehaviour
{
   // public List<GameObject> Points=new List<GameObject>();
   // public List<GameObject> Lines=new List<GameObject>();
    [SerializeField] GameObject p1,p2,p3,p4,p5,p6;
    [SerializeField] GameObject b1,b2,b3,b4,b5,b6;
    [SerializeField] GameObject yellow1,yellow2,yellow3,yellow4,yellow5,yellow6;

    [SerializeField] GameObject Line1,Line2,Line3,Line4;
    [SerializeField] GameObject bLine1,bLine2,bLine3,bLine4;
    [SerializeField] GameObject yellowLine1,yellowLine2,yellowLine3, yellowLine4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RedColor()
    {    LeanTween.scale(p1,new Vector3(0.042464168f,0.08388975f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void point1click()
     {
           LeanTween.scale(p2,new Vector3(0.0473485f,0.08544924f,0f),1f).setDelay(0f);
     }
     public void point2click()
     {  LeanTween.scale(Line1,new Vector3(0.109134f,0.0247415f,0f),0f).setDelay(2f);
      LeanTween.scale(p3,new Vector3(0.04999764f,0.1000031f,0f),1f).setDelay(0f);
        
        
        

     }
     public void point3click()
     {   LeanTween.scale(Line2,new Vector3(0.1211109f,0.0266285f,0f),0f).setDelay(2f);
         LeanTween.scale(p4,new Vector3(0.04396641f,0.1062951f,0f),1f).setDelay(0f);
     }
     public void point4click()
     {
        LeanTween.scale(Line3,new Vector3(0.0933674f,0.0266285f,0f),0f).setDelay(2f);
        LeanTween.scale(p5,new Vector3(0.04999764f,0.1000031f,0f),0.5f).setDelay(0.5f);

     }
     public void point5click()
     {  LeanTween.scale(p6,new Vector3(0.04546728f,0.09108272f,0f),0.5f).setDelay(0.5f);
     
         LeanTween.scale(Line3,new Vector3(0.0933674f,0.026625f,0f),0f).setDelay(2f);
     }
     public void point6click()
     {
        LeanTween.scale(Line4,new Vector3(0.05615767f,0.026625f,0f),0.5f).setDelay(0.5f);
     }
     public void RemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(Line4,new Vector3(0f,0f,0f),0f);
     }


/****************************************************************************************/

      public void BlueColor()
    {
        
      LeanTween.scale(b1,new Vector3(0.042464168f,0.08388975f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void bpoint1click()
     {
           LeanTween.scale(b2,new Vector3(0.0473485f,0.08544924f,0f),1f).setDelay(0f);
     }
     public void bpoint2click()
     {  LeanTween.scale(bLine1,new Vector3(0.109134f,0.0247415f,0f),0f).setDelay(2f);
      LeanTween.scale(b3,new Vector3(0.04999764f,0.1000031f,0f),1f).setDelay(0f);
        
        
        

     }
     public void bpoint3click()
     {   LeanTween.scale(bLine2,new Vector3(0.1211109f,0.0266285f,0f),0f).setDelay(2f);
         LeanTween.scale(b4,new Vector3(0.04396641f,0.1062951f,0f),1f).setDelay(0f);
     }
     public void bpoint4click()
     {
        LeanTween.scale(bLine3,new Vector3(0.0933674f,0.0266285f,0f),0f).setDelay(2f);
        LeanTween.scale(b5,new Vector3(0.04999764f,0.1000031f,0f),0.5f).setDelay(0.5f);

     }
     public void bpoint5click()
     {  LeanTween.scale(b6,new Vector3(0.04546728f,0.09108272f,0f),0.5f).setDelay(0.5f);
     
         LeanTween.scale(bLine3,new Vector3(0.0933674f,0.026625f,0f),0f).setDelay(2f);
     }
     public void bpoint6click()
     {
        LeanTween.scale(bLine4,new Vector3(0.05615767f,0.026625f,0f),0.5f).setDelay(0.5f);
     }
     
     public void bRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bLine1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bLine2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bLine3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bLine4,new Vector3(0f,0f,0f),0f);
     }

    /**********************************************************************************/
    public void YellowColor()
          {
            RemoveAll();
            bRemoveAll();
        LeanTween.scale(yellow1,new Vector3(0.042464168f,0.08388975f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void ypoint1click()
     {
           LeanTween.scale(yellow2,new Vector3(0.0473485f,0.08544924f,0f),1f).setDelay(0f);
     }
     public void ypoint2click()
     {  LeanTween.scale(yellowLine1,new Vector3(0.109134f,0.0247415f,0f),0f).setDelay(2f);
      LeanTween.scale(yellow3,new Vector3(0.04999764f,0.1000031f,0f),1f).setDelay(0f);
        
        
        

     }
     public void ypoint3click()
     {   LeanTween.scale(yellowLine2,new Vector3(0.1211109f,0.0266285f,0f),0f).setDelay(2f);
         LeanTween.scale(yellow4,new Vector3(0.04396641f,0.1062951f,0f),1f).setDelay(0f);
     }
     public void ypoint4click()
     {
        LeanTween.scale(yellowLine3,new Vector3(0.0933674f,0.0266285f,0f),0f).setDelay(2f);
        LeanTween.scale(yellow5,new Vector3(0.04999764f,0.1000031f,0f),0.5f).setDelay(0.5f);

     }
     public void ypoint5click()
     {  LeanTween.scale(yellow6,new Vector3(0.04546728f,0.09108272f,0f),0.5f).setDelay(0.5f);
     
         LeanTween.scale(yellowLine3,new Vector3(0.0933674f,0.026625f,0f),0f).setDelay(2f);
     }
     public void ypoint6click()
     {
        LeanTween.scale(yellowLine4,new Vector3(0.05615767f,0.026625f,0f),0.5f).setDelay(0.5f);
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
