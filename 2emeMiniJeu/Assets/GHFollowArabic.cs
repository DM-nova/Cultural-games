using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHFollowArabic : MonoBehaviour 
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
        LeanTween.scale(p1,new Vector3(0.02266801f,0.04340857f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02355818f,0.04644948f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.2298246f,0.1545617f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02472188f,0.05618696f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.2118144f,0.1331993f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.02567479f,0.06422602f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.3834345f,0.1572981f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02678565f,0.0652397f,0f),0.5f).setDelay(0.5f);
    }
     public void p5click()
    {     
          LeanTween.scale(l4,new Vector3(0.421418f,0.1767885f,0f),0f).setDelay(0f);
     LeanTween.scale(p6,new Vector3(0.02098574f,0.03621558f,0f),0.5f).setDelay(0.5f);
    }
     public void p6click()
    {
      LeanTween.scale(p6_1,new Vector3(0.02098574f,0.03621558f,0f),0.5f).setDelay(0.5f);
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
        LeanTween.scale(b1,new Vector3(0.03482905f,0.05122611f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03482905f,0.05122611f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.3593571f,0.1993065f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03367251f,0.06386128f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.3266882f,0.1814454f,0f),0f).setDelay(0f);
   LeanTween.scale(b4,new Vector3(0.03439369f,0.06803467f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.526502f,0.2172407f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.03409546f,0.05883933f,0f),0.5f).setDelay(0.5f);
    }
     public void b5click()
    {     
          LeanTween.scale(bl4,new Vector3(0.526502f,0.2172407f,0f),0f).setDelay(0f);
          LeanTween.scale(b6,new Vector3(0.03078036f,0.05311838f,0f),0.5f).setDelay(0.5f);
    }
     public void b6click()
    {
      LeanTween.scale(b6_1,new Vector3(0.03078036f,0.05311838f,0f),0.5f).setDelay(0.5f);
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
        LeanTween.scale(y1,new Vector3(0.031759f,0.06787752f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03227562f,0.06363758f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.3876428f,0.1725244f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03316578f,0.07349651f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.431955f,0.1627862f,0f),0f).setDelay(0f);
   LeanTween.scale(y4,new Vector3(0.03439369f,0.06803467f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.526502f,0.2172407f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.03409546f,0.05883933f,0f),0.5f).setDelay(0.5f);
    }
     public void y5click()
    {     
          LeanTween.scale(yl4,new Vector3(0.526502f,0.2172407f,0f),0f).setDelay(0f);
     LeanTween.scale(y6,new Vector3(0.03078036f,0.05311838f,0f),0.5f).setDelay(0.5f);
    }
     public void y6click()
    {
      LeanTween.scale(y6_1,new Vector3(0.03078036f,0.05311838f,0f),0.5f).setDelay(0.5f);
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
