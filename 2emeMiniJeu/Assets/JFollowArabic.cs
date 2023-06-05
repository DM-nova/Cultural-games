using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p6_1;
    [SerializeField] GameObject l1,l2,l3,l4;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b6_1;
    [SerializeField] GameObject bl1,bl2,bl3,bl4;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y6_1;
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
        LeanTween.scale(p1,new Vector3(0.02621089f,0.04744608f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.0263791f,0.05131611f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.1313679f,0.05678174f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02951924f,0.07061004f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.05472497f,0.3298287f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.0313224f,0.07699805f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.4643154f,0.2779987f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02994584f,0.070052f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(l4,new Vector3(0.3843639f,0.2767308f,0f),0f).setDelay(0f);
           LeanTween.scale(p6,new Vector3(0.02785551f,0.06021728f,0f),0.5f).setDelay(0.5f);
          
          
    }
    public void p6click()
    {     
          LeanTween.scale(p6_1,new Vector3(0.0274896f,0.04902667f,0f),0.5f).setDelay(0.5f);
          
          
    }
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
         
         
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
    {
        LeanTween.scale(b1,new Vector3(0.03619793f,0.0655243f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03454658f,0.0689277f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.2069045f,0.05678174f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03550821f,0.07810176f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.06774971f,0.4083291f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.04139252f,0.08948123f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.5546247f,0.3320694f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.02994584f,0.070052f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {     
          LeanTween.scale(bl4,new Vector3(0.5032861f,0.3623513f,0f),0f).setDelay(0f);
      LeanTween.scale(b6,new Vector3(0.04139252f,0.08948123f,0f),0.5f).setDelay(0.5f);
    }
    public void b6click()
    {     
          LeanTween.scale(b6_1,new Vector3(0.04139252f,0.07382201f,0f),0.5f).setDelay(0.5f);
    }
    
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
         
         
     }

     /************************************************************************************/
     public void arabAyellowColor()
    {
        LeanTween.scale(y1,new Vector3(0.03619793f,0.0655243f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03454658f,0.0689277f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1313679f,0.05678174f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03550821f,0.07810176f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.06774971f,0.4083291f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.04139252f,0.08948123f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.5546247f,0.3320694f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.02994584f,0.070052f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {     
          LeanTween.scale(yl4,new Vector3(0.5032861f,0.3623513f,0f),0f).setDelay(0f);
           LeanTween.scale(y6,new Vector3(0.04139252f,0.08948123f,0f),0.5f).setDelay(0.5f);
    }
    public void y6click()
    {     
          LeanTween.scale(y6_1,new Vector3(0.04139252f,0.07382201f,0f),0.5f).setDelay(0.5f);
          
          
    }
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
         
         
     }

}
