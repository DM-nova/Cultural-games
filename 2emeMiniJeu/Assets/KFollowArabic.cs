using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KFollowArabic : MonoBehaviour
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
        LeanTween.scale(p1,new Vector3(0.02488142f,0.05396901f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02418365f,0.05245827f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.7170888f,0.07466588f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02420529f,0.06149617f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.5950587f,0.1109992f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.02420529f,0.06149617f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.2316924f,0.07466588f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.01529823f,0.0347667f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(p6,new Vector3(0.01437346f,0.03488029f,0f),0.5f).setDelay(0.5f);
          
    }
     public void p6click()
    {      LeanTween.scale(l4,new Vector3(0.07738211f,0.1867102f,0f),0f).setDelay(0f);
          LeanTween.scale(p7,new Vector3(0.01489788f,0.03368123f,0f),0.5f).setDelay(0.5f);
          
    }
    public void p7click()
    {
       LeanTween.scale(l5,new Vector3(0.180438f,0.04423993f,0f),0f).setDelay(0f);
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
        LeanTween.scale(b1,new Vector3(0.02839965f,0.06160023f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02888737f,0.0626614f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.7170888f,0.09764898f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.02741491f,0.06965056f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.7586998f,0.1109992f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.02848479f,0.07236869f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.2316924f,0.08119915f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.01867914f,0.04245014f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {     
          LeanTween.scale(b6,new Vector3(0.01691469f,0.04104713f,0f),0.5f).setDelay(0.5f);
          
    }
     public void b6click()
    {      LeanTween.scale(bl4,new Vector3(0.08559235f,0.2065201f,0f),0f).setDelay(0f);
          LeanTween.scale(b7,new Vector3(0.01805772f,0.04082502f,0f),0.5f).setDelay(0.5f);
          
    }
    public void b7click()
    {
       LeanTween.scale(bl5,new Vector3(0.2027582f,0.04971241f,0f),0f).setDelay(0f);
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
        LeanTween.scale(y1,new Vector3(0.02839965f,0.06160023f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.02888737f,0.0626614f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.7170888f,0.09764898f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.02741491f,0.06965056f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.7586998f,0.1109992f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.02848479f,0.07236869f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.2316924f,0.08119915f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.01867914f,0.04245014f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {     
          LeanTween.scale(y6,new Vector3(0.01691469f,0.04104713f,0f),0.5f).setDelay(0.5f);
          
    }
     public void y6click()
    {      LeanTween.scale(yl4,new Vector3(0.08559235f,0.2065201f,0f),0f).setDelay(0f);
          LeanTween.scale(y7,new Vector3(0.01805772f,0.04082502f,0f),0.5f).setDelay(0.5f);
          
    }
    public void y7click()
    {
       LeanTween.scale(yl5,new Vector3(0.2027582f,0.04971241f,0f),0f).setDelay(0f);
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
