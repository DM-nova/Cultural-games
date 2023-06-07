using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAAFollowArabic : MonoBehaviour 
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
        LeanTween.scale(p1,new Vector3(0.02602703f,0.04869229f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02602703f,0.04869229f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.1782621f,0.324835f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02446497f,0.05817547f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.07431962f,0.4052536f,0f),0f).setDelay(0f);
          LeanTween.scale(p4,new Vector3(0.02446497f,0.05817547f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {     
          LeanTween.scale(l3,new Vector3(0.3321036f,0.2107854f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02446497f,0.05817547f,0f),0.5f).setDelay(0.5f);
    }
     public void p5click()
    {     
          LeanTween.scale(l4,new Vector3(0.284674f,0.1935073f,0f),0f).setDelay(0f);
   
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
        LeanTween.scale(b1,new Vector3(0.02786714f,0.05213484f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.02648771f,0.04955414f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.2381403f,0.4339471f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.02576161f,0.06125877f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.08811335f,0.5885741f,0f),0f).setDelay(0f);
          LeanTween.scale(b4,new Vector3(0.02792432f,0.06640148f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {     
          LeanTween.scale(bl3,new Vector3(0.4118726f,0.2544708f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.02684297f,0.06383013f,0f),0.5f).setDelay(0.5f);
    }
     public void b5click()
    {     
          LeanTween.scale(bl4,new Vector3(0.3877108f,0.2291709f,0f),0f).setDelay(0f);
   
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
        LeanTween.scale(y1,new Vector3(0.02786714f,0.05213484f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.02648771f,0.04955414f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.2381403f,0.4339471f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.02576161f,0.06125877f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.08811335f,0.5885741f,0f),0f).setDelay(0f);
          LeanTween.scale(y4,new Vector3(0.02792432f,0.06640148f,0f),0.5f).setDelay(0.5f);
    }
    public void y4click()
    {     
          LeanTween.scale(yl3,new Vector3(0.4118726f,0.2544708f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.02684297f,0.06383013f,0f),0.5f).setDelay(0.5f);
    }
     public void y5click()
    {     
          LeanTween.scale(yl4,new Vector3(0.3877108f,0.2291709f,0f),0f).setDelay(0f);
   
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
