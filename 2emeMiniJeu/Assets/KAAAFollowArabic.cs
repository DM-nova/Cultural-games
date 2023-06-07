using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAAAFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5,p5_1,p6,p6_1;
    [SerializeField] GameObject l1,l2,l3,l4;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b5_1,b6,b6_1;
    [SerializeField] GameObject bl1,bl2,bl3,bl4;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y5_1,y6,y6_1;
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
        LeanTween.scale(p1,new Vector3(0.01521319f,0.03195947f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.01557896f,0.03273216f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.06901658f,0.1923732f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.01461228f,0.04252118f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.1507601f,0.1961198f,0f),0f).setDelay(0f);
          LeanTween.scale(l3,new Vector3(0.3782814f,0.1468636f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.01461228f,0.04252118f,0f),0.5f).setDelay(0.5f);

    }
    public void p4click()
    {
      LeanTween.scale(l4,new Vector3(0.3916743f,0.1520644f,0f),0f).setDelay(0f);
      LeanTween.scale(p5,new Vector3(0.01368665f,0.04252118f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
      LeanTween.scale(p5_1,new Vector3(0.01539608f,0.04252118f,0f),0.5f).setDelay(0.5f);
      LeanTween.scale(p6,new Vector3(0.01368665f,0.04252118f,0f),0.5f).setDelay(0.5f);
    }
     public void p6click()
    {
      LeanTween.scale(p6_1,new Vector3(0.0150639f,0.04252118f,0f),0.5f).setDelay(0.5f);
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
         LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);
         

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
  {
        LeanTween.scale(b1,new Vector3(0.02704601f,0.05681755f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02563051f,0.05385095f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.1080593f,0.3011987f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.0318519f,0.07973146f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.2945111f,0.3831217f,0f),0f).setDelay(0f);
          LeanTween.scale(bl3,new Vector3(0.6758376f,0.2623865f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.02649499f,0.0770994f,0f),0.5f).setDelay(0.5f);

    }
    public void b4click()
    {
      LeanTween.scale(bl4,new Vector3(0.7136306f,0.2770613f,0f),0f).setDelay(0f);
      LeanTween.scale(b5,new Vector3(0.02082424f,0.06469598f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
      LeanTween.scale(b5_1,new Vector3(0.02204094f,0.06772127f,0f),0.5f).setDelay(0.5f);
      LeanTween.scale(b6,new Vector3(0.02070057f,0.06752735f,0f),0.5f).setDelay(0.5f);
    }
     public void b6click()
    {
      LeanTween.scale(b6_1,new Vector3(0.02144943f,0.06811397f,0f),0.5f).setDelay(0.5f);
    }
    
       public void bbRemoveAll()
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
         LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
      {
        LeanTween.scale(y1,new Vector3(0.03203294f,0.0737468f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03249917f,0.07005732f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1129387f,0.3147995f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03634804f,0.08461715f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.2587043f,0.3365416f,0f),0f).setDelay(0f);
          LeanTween.scale(yl3,new Vector3(0.7048801f,0.2736619f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.0264647f,0.06770222f,0f),0.5f).setDelay(0.5f);

    }
    public void y4click()
    {
      LeanTween.scale(yl4,new Vector3(0.7084764f,0.2750603f,0f),0f).setDelay(0f);
      LeanTween.scale(y5,new Vector3(0.01453385f,0.04515324f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {
      LeanTween.scale(y5_1,new Vector3(0.0163491f,0.04515324f,0f),0.5f).setDelay(0.5f);
      LeanTween.scale(y6,new Vector3(0.01501699f,0.04665424f,0f),0.5f).setDelay(0.5f);
    }
     public void y6click()
    {
      LeanTween.scale(y6_1,new Vector3(0.01652811f,0.04665424f,0f),0.5f).setDelay(0.5f);
    }
    
       public void yyRemoveAll()
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
         LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);
       
     }

}
