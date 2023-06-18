using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4;
        [SerializeField] GameObject l1,l2;

         [SerializeField] GameObject b1,b2,b3,b4;
        [SerializeField] GameObject bl1,bl2;

         [SerializeField] GameObject y1,y2,y3,y4;
        [SerializeField] GameObject yl1,yl2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BRedColor()
    {
        LeanTween.scale(p1,new Vector3(0.02679731f,0.0475f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02679731f,0.0475f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.1787546f,0.0420743f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.02545745f,0.06828125f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
        LeanTween.scale(p4,new Vector3(0.02545745f,0.06555f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {
        LeanTween.scale(l2,new Vector3(0.1161887f,0.0420743f,0f),0.2f).setDelay(0f);
    }
    
     public void rrBRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         }

     /************************************************************************************/
      public void BblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.02679731f,0.0475f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02679731f,0.0475f,0f),0f).setDelay(0f);
    }
    public void b2click()
    {  
        LeanTween.scale(bl1,new Vector3(0.1787546f,0.0420743f,0f),0f).setDelay(0f);
        LeanTween.scale(b3,new Vector3(0.02545745f,0.06828125f,0f),0.5f).setDelay(0.5f);

    }
    public void b3click()
    {
        LeanTween.scale(b4,new Vector3(0.02545745f,0.06555f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {
        LeanTween.scale(bl2,new Vector3(0.1161887f,0.0420743f,0f),0.2f).setDelay(0f);
    }
    
     public void bbBRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         }

     /*******************************************************************/
          public void yellowColor()
       {
        LeanTween.scale(y1,new Vector3(0.02679731f,0.0475f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.02679731f,0.0475f,0f),0f).setDelay(0f);
    }
    public void y2click()
    {  
        LeanTween.scale(yl1,new Vector3(0.1787546f,0.0420743f,0f),0f).setDelay(0f);
        LeanTween.scale(y3,new Vector3(0.02545745f,0.06828125f,0f),0.5f).setDelay(0.5f);

    }
    public void y3click()
    {
        LeanTween.scale(y4,new Vector3(0.02545745f,0.06555f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {
        LeanTween.scale(yl2,new Vector3(0.1161887f,0.0420743f,0f),0.2f).setDelay(0f);
    }
    
     public void yyBRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         }

}
