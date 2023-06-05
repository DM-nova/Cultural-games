using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4;
    [SerializeField] GameObject l1,l2,l3;

    [SerializeField] GameObject b1,b2,b3,b4;
    [SerializeField] GameObject bl1,bl2,bl3;

    [SerializeField] GameObject y1,y2,y3,y4;
    [SerializeField] GameObject yl1,yl2,yl3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.02567442f,0.043813f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02567442f,0.043813f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.08784968f,0.3791672f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02505284f,0.05730961f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.08784968f,0.3288889f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.0260792f,0.05506055f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.07886443f,0.1636819f,0f),0f).setDelay(0f);
    }
   
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
      {
        LeanTween.scale(b1,new Vector3(0.03995655f,0.08396082f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03996766f,0.09622322f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.09883089f,0.5260945f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.04011004f,0.08066259f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.09663465f,0.5614236f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.04134008f,0.08063966f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.08872249f,0.1923262f,0f),0f).setDelay(0f);
    }
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
    {
        LeanTween.scale(y1,new Vector3(0.03995655f,0.08396082f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03996766f,0.09622322f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.09883089f,0.5260945f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.04011004f,0.08066259f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.09663465f,0.5614236f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.04134008f,0.08063966f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.08872249f,0.1923262f,0f),0f).setDelay(0f);
    }
   
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
       
     }

}
