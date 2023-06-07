using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAAFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5;
    [SerializeField] GameObject l1,l2,l3,l4;

    [SerializeField] GameObject b1,b2,b3,b4,b5;
    [SerializeField] GameObject bl1,bl2,bl3,bl4;

    [SerializeField] GameObject y1,y2,y3,y4,y5;
    [SerializeField] GameObject yl1,yl2,yl3,yl4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {  LeanTween.scale(p1,new Vector3(0.02623f,0.04906641f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02603426f,0.04870674f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.1968134f,0.3586366f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02597403f,0.06177156f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.07857048f,0.5662029f,0f),0f).setDelay(0f);
          LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(p4,new Vector3(0.02468913f,0.058717f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
      LeanTween.scale(p5,new Vector3(0.02337914f,0.05560159f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(l3,new Vector3(0.4644087f,0.06729886f,0f),0f).setDelay(0f);
    }
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         
       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
      {
        LeanTween.scale(b1,new Vector3(0.03381915f,0.063265f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03213831f,0.06012899f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.2889724f,0.5265778f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03125898f,0.07433832f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1069202f,0.7705255f,0f),0f).setDelay(0f);
          LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(b4,new Vector3(0.0338814f,0.08057921f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
      LeanTween.scale(b5,new Vector3(0.0338814f,0.08057921f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {     
          LeanTween.scale(bl3,new Vector3(0.67243f,0.09744213f,0f),0f).setDelay(0f);
    }
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         
       
     }
     /************************************************************************************/
     public void arabAyellowColor()
   {
        LeanTween.scale(y1,new Vector3(0.03138348f,0.06335837f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03210718f,0.06381749f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.2559547f,0.4980737f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03054306f,0.07262634f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.1013329f,0.7945789f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.02792064f,0.066401f,0f),0.5f).setDelay(0.5f);
    }
     public void y4click()
    {     
      LeanTween.scale(y5,new Vector3(0.03164028f,0.07525655f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {     
          LeanTween.scale(yl3,new Vector3(0.6388053f,0.08313162f,0f),0f).setDelay(0f);
    }
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
       
     }
}
