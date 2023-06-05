using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aFollowArabic : MonoBehaviour
{
    [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7;
    [SerializeField] GameObject l1,l2,l3,l4,l5;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b7;
    [SerializeField] GameObject bl1,bl2,bl3,bl4,bl5;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y7;
    [SerializeField] GameObject yl1,yl2,yl3,yl4,yl5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.03180812f,0.0572546f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.03091732f,0.05565118f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.760767f,0.07414063f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02736466f,0.05607745f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          
          LeanTween.scale(p4,new Vector3(0.02571676f,0.0562665f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l2,new Vector3(0.1384347f,0.3011771f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02665387f,0.05432619f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(l3,new Vector3(0.3227955f,0.07136411f,0f),0f).setDelay(0f);
          
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
     /**********************************************************************************************/
    
     public void arabAblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.03180812f,0.0572546f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03091732f,0.05565118f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.760767f,0.07414063f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.02736466f,0.05607745f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          
          LeanTween.scale(b4,new Vector3(0.02571676f,0.0562665f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1384347f,0.3011771f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.02665387f,0.05432619f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {     
          LeanTween.scale(bl3,new Vector3(0.4196341f,0.07136411f,0f),0f).setDelay(0f);
          
    }
    
    
       public void bbRemoveAll()
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

     /************************************************************************************/
     public void arabAyellowColor()
    {
        LeanTween.scale(y1,new Vector3(0.03180812f,0.0572546f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03091732f,0.05565118f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.8463532f,0.07414063f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.02736466f,0.05607745f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          
          LeanTween.scale(y4,new Vector3(0.02571676f,0.0562665f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl2,new Vector3(0.1384347f,0.3011771f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.02665387f,0.05432619f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {     
          LeanTween.scale(yl3,new Vector3(0.3954245f,0.07136411f,0f),0f).setDelay(0f);
          
    }
    
    
       public void yyRemoveAll()
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
