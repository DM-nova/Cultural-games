using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3;
    [SerializeField] GameObject l1,l2,l3;

    [SerializeField] GameObject b1,b2,b3;
    [SerializeField] GameObject bl1,bl2,bl3;

    [SerializeField] GameObject y1,y2,y3;
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
          

    }
   
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         
         

       
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
    }
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         

         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         
       
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
      }
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
        
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         
       
     }

}
