using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tFollowArabic : MonoBehaviour
{
    [SerializeField] GameObject p1,p2,p3,p4,p5,p5_1,p6,p6_1;
    [SerializeField] GameObject l1,l2,l3;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b5_1,b6,b6_1;
    [SerializeField] GameObject bl1,bl2,bl3;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y5_1,y6,y6_1;
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
        LeanTween.scale(p1,new Vector3(0.02865112f,0.05005712f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02817406f,0.052247f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.08191993f,0.2371875f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02814338f,0.06003921f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.093371f,0.5875781f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.02787123f,0.06512197f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.08191993f,0.237187f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.027871f,0.06512197f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(p5_1,new Vector3(0.027195f,0.0605172f,0f),0f).setDelay(0f);
          LeanTween.scale(p6,new Vector3(0.027871f,0.07489026f,0f),0.5f).setDelay(0.5f);
          
    }
    public void p6click()
    {     
          LeanTween.scale(p6_1,new Vector3(0.027871f,0.06512197f,0f),0f).setDelay(0f);
          
    }
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5_1,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6_1,new Vector3(0f,0f,0f),0f);
          
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         
         
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.05213675f,0.07762983f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.05026144f,0.07745834f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.1443839f,0.3528164f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.05023437f,0.09421243f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1283851f,1.006227f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.05078723f,0.09648537f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.1458922f,0.3773351f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.04875155f,0.1035549f,0f),0.5f).setDelay(0.5f);
    }
     public void b5click()
    {     
          LeanTween.scale(b5_1,new Vector3(0.04916346f,0.07908841f,0f),0f).setDelay(0f);
          LeanTween.scale(b6,new Vector3(0.0505f,0.1025f,0f),0.5f).setDelay(0.5f);
          
    }
    public void b6click()
    {     
          LeanTween.scale(b6_1,new Vector3(0.05075336f,0.0769514f,0f),0f).setDelay(0f);
          
    }
    
       public void aaBRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6_1,new Vector3(0f,0f,0f),0f);
          
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         
         
     }

     /************************************************************************************/
     public void arabAyellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.04829157f,0.09392916f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.04757221f,0.0914765f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1351679f,0.3528164f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.04705503f,0.08923028f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.119048f,1.006227f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.047726f,0.09390588f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.1307194f,0.3773351f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.04875155f,0.1035549f,0f),0.5f).setDelay(0.5f);
    }
     public void y5click()
    {     
          LeanTween.scale(y5_1,new Vector3(0.04916346f,0.07908841f,0f),0f).setDelay(0f);
          LeanTween.scale(y6,new Vector3(0.0505f,0.1025f,0f),0.5f).setDelay(0.5f);
          
    }
    public void y6click()
    {     
          LeanTween.scale(y6_1,new Vector3(0.05075336f,0.0769514f,0f),0f).setDelay(0f);
          
    }
    
    
       public void aaYRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6_1,new Vector3(0f,0f,0f),0f);
          
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         
         
     }

}
