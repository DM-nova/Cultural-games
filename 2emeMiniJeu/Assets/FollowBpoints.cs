using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBpoints : MonoBehaviour
{
        [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7;
        [SerializeField] GameObject l1,l2,l3,l4,l5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BRedColor()
    {
        LeanTween.scale(p1,new Vector3(0.05f,0.1f,0.5f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {  
        LeanTween.scale(l1,new Vector3(0.1587966f,0.9148214f,0f),0f).setDelay(0f);
        LeanTween.scale(p3,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);

    }
    public void p3click()
    {
        LeanTween.scale(l2,new Vector3(0.85f,0.4724862f,0f),0f).setDelay(0f);
        LeanTween.scale(p4,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);
    }
    public void p4click()
    {
        LeanTween.scale(l3,new Vector3(0.7506447f,0.46248f,0f),0f).setDelay(0f);
        LeanTween.scale(p5,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);
    }
     public void p5click()
    {
        
        LeanTween.scale(p6,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);
    }
      public void p6click()
    {
        LeanTween.scale(l4,new Vector3(1.456289f,0.5630313f,0f),0f).setDelay(0f);
        LeanTween.scale(p7,new Vector3(0.05f,0.1f,0f),0f).setDelay(0f);
    }
      public void p7click()
    {
        LeanTween.scale(l5,new Vector3(0.833625f,0.5242275f,0f),0f).setDelay(0f).setOnComplete(BRemoveAll);
        
    }
     public void BRemoveAll()
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

}
