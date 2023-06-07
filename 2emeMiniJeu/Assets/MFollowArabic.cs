using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MFollowArabic : MonoBehaviour 
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
    {
        LeanTween.scale(p1,new Vector3(0.02453381f,0.03649685f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02642906f,0.03649685f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.09231152f,0.1988655f,0f),0f).setDelay(0f);
          LeanTween.scale(p1,new Vector3(0f,0f,0f),0.2f);
          LeanTween.scale(p3,new Vector3(0.02469353f,0.04697144f,0f),0.5f).setDelay(0.5f);
          
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.09300191f,0.1959592f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.02249759f,0.04641145f,0f),0.5f).setDelay(0.5f);
    }
     public void p4click()
    {
      LeanTween.scale(l3,new Vector3(0.064333f,0.1736895f,0f),0f).setDelay(0f);
      LeanTween.scale(p5,new Vector3(0.02249759f,0.04641145f,0f),0.5f).setDelay(0.5f);
    }
     public void p5click()
    {
      LeanTween.scale(l4,new Vector3(0.05550265f,0.4490198f,0f),0f).setDelay(0f);
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
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.0320353f,0.04989934f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03107704f,0.04639354f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.1402168f,0.3020683f,0f),0f).setDelay(0f);
          LeanTween.scale(b1,new Vector3(0f,0f,0f),0.2f);
          LeanTween.scale(b3,new Vector3(0.03342205f,0.06357979f,0f),0.5f).setDelay(0.5f);
          
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1347789f,0.2839861f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.0281867f,0.0581419f,0f),0.5f).setDelay(0.5f);
    }
     public void b4click()
    {
      LeanTween.scale(bl3,new Vector3(0.08439648f,0.315367f,0f),0f).setDelay(0f);
      LeanTween.scale(b5,new Vector3(0.02249759f,0.04641145f,0f),0.5f).setDelay(0.5f);
    }
     public void b5click()
    {
      LeanTween.scale(bl4,new Vector3(0.09723151f,0.5937296f,0f),0f).setDelay(0f);
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
         LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.0320353f,0.04989934f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03107704f,0.04639354f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1402168f,0.3020683f,0f),0f).setDelay(0f);
          LeanTween.scale(y1,new Vector3(0f,0f,0f),0.2f);
          LeanTween.scale(y3,new Vector3(0.03342205f,0.06357979f,0f),0.5f).setDelay(0.5f);
          
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.1347789f,0.2839861f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.0281867f,0.0581419f,0f),0.5f).setDelay(0.5f);
    }
     public void y4click()
    {
      LeanTween.scale(yl3,new Vector3(0.08439648f,0.315367f,0f),0f).setDelay(0f);
      LeanTween.scale(y5,new Vector3(0.02249759f,0.04641145f,0f),0.5f).setDelay(0.5f);
    }
     public void y5click()
    {
      LeanTween.scale(yl4,new Vector3(0.09723151f,0.5937296f,0f),0f).setDelay(0f);
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
