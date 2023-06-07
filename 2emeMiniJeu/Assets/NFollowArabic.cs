using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5,p5_1;
    [SerializeField] GameObject l1,l2,l3;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b5_1;
    [SerializeField] GameObject bl1,bl2,bl3;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y5_1;
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
        LeanTween.scale(p1,new Vector3(0.02008297f,0.0390233f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02018921f,0.03980415f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.3411734f,0.1518429f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02090533f,0.0463257f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.09273871f,0.2748022f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.01955571f,0.04976241f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.341173f,0.1518422f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02232184f,0.0567949f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
          LeanTween.scale(p5_1,new Vector3(0.02232184f,0.04900084f,0f),0.5f).setDelay(0.5f);
    }
   
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);

       
     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.03392817f,0.06592596f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03232292f,0.06372644f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.5138112f,0.2345408f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03402552f,0.0753997f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1646245f,0.4878134f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.03200096f,0.0814312f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.5368751f,0.2091563f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.0353444f,0.08992904f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
          LeanTween.scale(b5_1,new Vector3(0.03302455f,0.07249539f,0f),0.5f).setDelay(0.5f);
    }
   
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
        {
        LeanTween.scale(y1,new Vector3(0.03392817f,0.06592596f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03232292f,0.06372644f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.5138112f,0.2345408f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03402552f,0.0753997f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.1646245f,0.4878134f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.03200096f,0.0814312f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.5368751f,0.2091563f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.0353444f,0.08992904f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {
          LeanTween.scale(y5_1,new Vector3(0.03302455f,0.07249539f,0f),0.5f).setDelay(0.5f);
    }
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
       
     }

}
