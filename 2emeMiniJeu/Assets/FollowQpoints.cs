using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FollowQpoints : MonoBehaviour
{
   // public List<GameObject> Points=new List<GameObject>();
   // public List<GameObject> Lines=new List<GameObject>();
    [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7;
    [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b7;
    [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y7;

    [SerializeField] GameObject l1,l2,l3,l4,l5;
    [SerializeField] GameObject bl1,bl2,bl3,bl4,bl5;
    [SerializeField] GameObject yl1,yl2,yl3, yl4,yl5;

    void Start()
    {  }
    void Update()
    {    
    }
    public void RedColor()
    {
   LeanTween.scale(p1,new Vector3(0.040506f,0.06302936f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void point1click()
     {
    LeanTween.scale(p2,new Vector3(0.040506f,0.06699806f,0f),0.5f).setDelay(0.5f);
     }
     public void point2click()
     {  
        LeanTween.scale(l1,new Vector3(0.02192524f,0.1395271f,0f),0.5f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.04328809f,0.08088388f,0.5f),0.5f).setDelay(0.5f);
     }
 public void point3click()
     {   LeanTween.scale(l2,new Vector3(0.02158786f,0.1388899f,0f),0.5f).setDelay(0f);
         LeanTween.scale(p4,new Vector3(0.04039544f,0.08005108f,0f),0.5f).setDelay(0.5f);
     }
     public void point4click()
     { LeanTween.scale(l3,new Vector3(0.02057575f,0.1172824f,0f),0.5f).setDelay(0f);
     LeanTween.scale(p5,new Vector3(0.040506f,0.08019981f,0f),0.5f).setDelay(0.5f);     }
     
 public void point5click()
     {
    LeanTween.scale(l4,new Vector3(0.01906045f,0.1235987f,0f),0.5f).setDelay(0f);
     LeanTween.scale(p6,new Vector3(0.02680774f,0.05661648f,0f),0.5f).setDelay(0.5f);    
 }   
  public void point6click()
     { LeanTween.scale(p7,new Vector3(0.02495288f,0.05538919f,0f),0.5f).setDelay(0.5f);    
 } 
 public void point7click()
     {
           LeanTween.scale(l5,new Vector3(0.01831336f,0.07768083f,0f),0.5f).setDelay(0f); 
     }


     public void RemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
           LeanTween.scale(p7,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l5,new Vector3(0f,0f,0f),0f);
         
     }


/****************************************************************************************/

      public void BlueColor()
  {
   LeanTween.scale(b1,new Vector3(0.040506f,0.06302936f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void bpoint1click()
     {
    LeanTween.scale(b2,new Vector3(0.040506f,0.06699806f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint2click()
     {  
        LeanTween.scale(bl1,new Vector3(0.02250625f,0.1432246f,0f),0.5f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.04328809f,0.08088388f,0.5f),0.5f).setDelay(0.5f);
     }
 public void bpoint3click()
     {   LeanTween.scale(bl2,new Vector3(0.02243034f,0.1443102f,0f),0.5f).setDelay(0f);
         LeanTween.scale(b4,new Vector3(0.04039544f,0.08005108f,0f),0.5f).setDelay(0.5f);
     }
     public void bpoint4click()
     { LeanTween.scale(bl3,new Vector3(0.0222607f,0.1369741f,0f),0.5f).setDelay(0f);
     LeanTween.scale(b5,new Vector3(0.040506f,0.08019981f,0f),0.5f).setDelay(0f);     }
     
 public void bpoint5click()
     {
    LeanTween.scale(bl4,new Vector3(0.0217556f,0.1410756f,0f),0.5f).setDelay(0f);
      LeanTween.scale(b6,new Vector3(0.02680774f,0.05661648f,0f),0.5f).setDelay(0.5f);    
 }   
  public void bpoint6click()
     { LeanTween.scale(b7,new Vector3(0.02495288f,0.05538919f,0f),0.5f).setDelay(0.5f);    
 } 
 public void bpoint7click()
     {
           LeanTween.scale(bl5,new Vector3(0.02041756f,0.08660636f,0f),0.5f).setDelay(0f); 
     }
     
     public void bRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(b7,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl5,new Vector3(0f,0f,0f),0f);
     }



    /**********************************************************************************/
    public void YellowColor()
 {
   LeanTween.scale(y1,new Vector3(0.040506f,0.06302936f,0f),0.5f).setDelay(0.5f)/*.setEase(LeanTweenType.easeOutElastic)*/;
    }
     public void ypoint1click()
     {
    LeanTween.scale(y2,new Vector3(0.040506f,0.06699806f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint2click()
     {  
        LeanTween.scale(yl1,new Vector3(0.02250625f,0.1432246f,0f),0.5f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.04328809f,0.08088388f,0.5f),0.5f).setDelay(0.5f);
     }
 public void ypoint3click()
     {   LeanTween.scale(yl2,new Vector3(0.02243034f,0.1443102f,0f),0.5f).setDelay(0f);
         LeanTween.scale(y4,new Vector3(0.04039544f,0.08005108f,0f),0.5f).setDelay(0.5f);
     }
     public void ypoint4click()
     { LeanTween.scale(yl3,new Vector3(0.0222607f,0.1369741f,0f),0.5f).setDelay(0f);
     LeanTween.scale(y5,new Vector3(0.040506f,0.08019981f,0f),0.5f).setDelay(0f);     }
     
 public void ypoint5click()
     {
    LeanTween.scale(yl4,new Vector3(0.0217556f,0.1410756f,0f),0.5f).setDelay(0f);
          LeanTween.scale(y6,new Vector3(0.02680774f,0.05661648f,0f),0.5f).setDelay(0.5f);    
 }   
  public void ypoint6click()
     { LeanTween.scale(y7,new Vector3(0.02495288f,0.05538919f,0f),0.5f).setDelay(0.5f);    
 } 
 public void ypoint7click()
     {
           LeanTween.scale(yl5,new Vector3(0.02041756f,0.08660636f,0f),0.5f).setDelay(0f); 
     }
    
     public void yRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(y7,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(yl5,new Vector3(0f,0f,0f),0f);
     }



}

