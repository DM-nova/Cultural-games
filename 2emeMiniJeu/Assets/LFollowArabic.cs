using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3;
    [SerializeField] GameObject l1,l2;

    [SerializeField] GameObject b1,b2,b3;
    [SerializeField] GameObject bl1,bl2;

    [SerializeField] GameObject y1,y2,y3;
    [SerializeField] GameObject yl1,yl2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.02705321f,0.04797656f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02556014f,0.05039866f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.4857289f,0.05752642f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02763376f,0.06123902f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.1747735f,0.3185704f,0f),0f).setDelay(0f);
    }
   
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.04409047f,0.07818919f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.043117f,0.08501343f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.6106862f,0.1155171f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.04107913f,0.09103278f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.3104284f,0.6135663f,0f),0f).setDelay(0f);
    }
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.04409047f,0.07818919f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.043117f,0.08501343f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.6106862f,0.1155171f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.04107913f,0.09103278f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.3104284f,0.6135663f,0f),0f).setDelay(0f);
    }
   
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
       
     }

}
