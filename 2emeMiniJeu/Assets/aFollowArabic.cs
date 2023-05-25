using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aFollowArabic : MonoBehaviour
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
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.05f,0.07f,0.5f),0f).setDelay(0f).setEase(LeanTweenType.easeOutElastic);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.1410279f,0.6525f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
    public void p3click()
    {     
          
          LeanTween.scale(p4,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
    public void p4click()
    {     
          LeanTween.scale(l2,new Vector3(0.4511719f,0.1056562f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
    public void p5click()
    {     
          LeanTween.scale(l3,new Vector3(0.1142578f,0.265459f,0f),0f).setDelay(0f);
          LeanTween.scale(p6,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
     public void p6click()
    {     
          LeanTween.scale(l4,new Vector3(0.3191778f,0.112827f,0f),0f).setDelay(0);
          LeanTween.scale(p7,new Vector3(0.05f,0.07f,0f),0f).setDelay(0f);
    }
     public void p7click()
    {     
          LeanTween.scale(l5,new Vector3(0.2837136f,0.112827f,0f),0f).setDelay(1f).setOnComplete(aaRemoveAll);
          
    }
       public void aaRemoveAll()
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
