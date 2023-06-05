using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p4_1;
    [SerializeField] GameObject l1,l2;

    [SerializeField] GameObject b1,b2,b3,b4,b4_1;
    [SerializeField] GameObject bl1,bl2;

    [SerializeField] GameObject y1,y2,y3,y4,y4_1;
    [SerializeField] GameObject yl1,yl2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.02967609f,0.052627f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02749225f,0.05420626f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.4235288f,0.1884959f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02903021f,0.06433194f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.3251133f,0.1671867f,0f),0f).setDelay(0f);
        LeanTween.scale(p4,new Vector3(0.0254759f,0.05987049f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {  LeanTween.scale(p4_1,new Vector3(0.02703186f,0.05208918f,0f),0.5f).setDelay(0.5f);
    }
   
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.03095589f,0.05489657f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03227562f,0.06363758f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.6106862f,0.2717922f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03316578f,0.07349651f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.5567391f,0.1993216f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.03095589f,0.05489657f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {  LeanTween.scale(b4_1,new Vector3(0.03560856f,0.06314753f,0f),0.5f).setDelay(0.5f);
    }
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.03095589f,0.05489657f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03227562f,0.06363758f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.6106862f,0.2717922f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03316578f,0.07349651f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.5567391f,0.1993216f,0f),0f).setDelay(0f);
    LeanTween.scale(y4,new Vector3(0.03095589f,0.05489657f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {  LeanTween.scale(y4_1,new Vector3(0.03560856f,0.06314753f,0f),0.5f).setDelay(0.5f);
    }
   
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
       
     }

}
