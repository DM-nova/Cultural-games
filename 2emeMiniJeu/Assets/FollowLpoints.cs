using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3;
        [SerializeField] GameObject l1,l2;

         [SerializeField] GameObject b1,b2,b3;
        [SerializeField] GameObject bl1,bl2;

         [SerializeField] GameObject y1,y2,y3;
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
        LeanTween.scale(p1,new Vector3(0.02375f,0.05f,0.05f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02375f,0.05f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.1827861f,0.03844852f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.02375f,0.055625f,0f),0.5f).setDelay(0.5f);

    }
    public void p3click()
    {
        LeanTween.scale(l2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
    }
    
     public void rrBRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);

         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         }

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
        LeanTween.scale(bl2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
    }
    
     public void bbBRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
        
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         }
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
         LeanTween.scale(yl2,new Vector3(0.09964975f,0.03955437f,0f),0.2f).setDelay(0f);
    }
   
     public void yyBRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
       
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         }
}
