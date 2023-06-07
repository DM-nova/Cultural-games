using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p6_1;
    [SerializeField] GameObject l1,l2,l3,l4,l5;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b6_1;
    [SerializeField] GameObject bl1,bl2,bl3,bl4,bl5;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y6_1;
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
        LeanTween.scale(p1,new Vector3(0.01521193f,0.03196025f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.01557934f,0.03273216f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.06901685f,0.1923749f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.01461057f,0.04252199f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.1507601f,0.1961198f,0f),0f).setDelay(0f);
          LeanTween.scale(l3,new Vector3(0.06035386f,0.1611698f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.01386432f,0.02912891f,0f),0.5f).setDelay(0.5f);

    }
    public void p4click()
    {
      LeanTween.scale(l4,new Vector3(0.07165209f,0.3984357f,0f),0f).setDelay(0f);
      LeanTween.scale(p5,new Vector3(0.01406503f,0.03829059f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
      LeanTween.scale(l5,new Vector3(0.06035386f,0.05659798f,0f),0f).setDelay(0f);
      LeanTween.scale(p6,new Vector3(0.01294067f,0.03633832f,0f),0.5f).setDelay(0.5f);
    }
     public void p6click()
    {
      LeanTween.scale(p6_1,new Vector3(0.01386432f,0.02912891f,0f),0.5f).setDelay(0.5f);
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
         LeanTween.scale(l5,new Vector3(0f,0f,0f),0f);

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.02470682f,0.05191154f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02067591f,0.0434373f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.1159936f,0.3233052f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.02274583f,0.07198825f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.2653705f,0.3452106f,0f),0f).setDelay(0f);
          LeanTween.scale(bl3,new Vector3(0.1051693f,0.2808406f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.02638766f,0.05960761f,0f),0.5f).setDelay(0.5f);

    }
    public void b4click()
    {
      LeanTween.scale(bl4,new Vector3(0.1343506f,0.7470638f,0f),0f).setDelay(0f);
      LeanTween.scale(b5,new Vector3(0.02364072f,0.06435443f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
      LeanTween.scale(bl5,new Vector3(0.1117448f,0.1214953f,0f),0f).setDelay(0f);
      LeanTween.scale(b6,new Vector3(0.02163305f,0.06075152f,0f),0.5f).setDelay(0.5f);
    }
     public void b6click()
    {
      LeanTween.scale(b6_1,new Vector3(0.02024013f,0.04251906f,0f),0.5f).setDelay(0.5f);
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
         LeanTween.scale(bl5,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
          {
        LeanTween.scale(y1,new Vector3(0.02470682f,0.05191154f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.02067591f,0.0434373f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1159936f,0.3233052f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.02274583f,0.07198825f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.2653705f,0.3452106f,0f),0f).setDelay(0f);
          LeanTween.scale(yl3,new Vector3(0.1051693f,0.2808406f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.02638766f,0.05960761f,0f),0.5f).setDelay(0.5f);

    }
    public void y4click()
    {
      LeanTween.scale(yl4,new Vector3(0.1343506f,0.7470638f,0f),0f).setDelay(0f);
      LeanTween.scale(y5,new Vector3(0.02364072f,0.06435443f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {
      LeanTween.scale(yl5,new Vector3(0.1117448f,0.1214953f,0f),0f).setDelay(0f);
      LeanTween.scale(y6,new Vector3(0.02163305f,0.06075152f,0f),0.5f).setDelay(0.5f);
    }
     public void y6click()
    {
      LeanTween.scale(y6_1,new Vector3(0.02024013f,0.04251906f,0f),0.5f).setDelay(0.5f);
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
         LeanTween.scale(yl5,new Vector3(0f,0f,0f),0f);
       
     }

}
