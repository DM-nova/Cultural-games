using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chFollowArabic : MonoBehaviour 
{
   [SerializeField] GameObject p1,p2,p3,p4,p5,p6,p7,p8,p8_1,p9,p9_1,p10,p10_1;
    [SerializeField] GameObject l1,l1_1,l2,l2_2,l3,l3_3,l4;

    [SerializeField] GameObject b1,b2,b3,b4,b5,b6,b7,b8,b8_1,b9,b9_1,b10,b10_1;
    [SerializeField] GameObject bl1,bl1_1,bl2,bl2_2,bl3,bl3_3,bl4;

    [SerializeField] GameObject y1,y2,y3,y4,y5,y6,y7,y8,y8_1,y9,y9_1,y10,y10_1;
    [SerializeField] GameObject yl1,yl1_1,yl2,yl2_2,yl3,yl3_3,yl4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void arabARedColor()
    {
        LeanTween.scale(p1,new Vector3(0.02231001f,0.03864296f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02349243f,0.0477672f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.09655454f,0.2803544f,0f),0f).setDelay(0f);
          LeanTween.scale(l1_1,new Vector3(0.05886645f,0.1091552f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02251235f,0.05236411f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(p4,new Vector3(0.02228257f,0.05029912f,0f),0f).setDelay(0f);
    }
       public void p4click()
    {     
          LeanTween.scale(l2,new Vector3(0.09655454f,0.2803544f,0f),0f).setDelay(0f);
          LeanTween.scale(l2_2,new Vector3(0.05886645f,0.1091552f,0f),0f).setDelay(0f);
          LeanTween.scale(p5,new Vector3(0.02313749f,0.04857739f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {     
          LeanTween.scale(p6,new Vector3(0.02119651f,0.04876741f,0f),0f).setDelay(0f);
    }
      public void p6click()
    {     
          LeanTween.scale(l3,new Vector3(0.09655454f,0.2803544f,0f),0f).setDelay(0f);
           LeanTween.scale(l3_3,new Vector3(0.2850881f,0.1811911f,0f),0f).setDelay(0f);
          LeanTween.scale(p7,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
    }
     public void p7click()
    {     
          LeanTween.scale(l4,new Vector3(0.289893f,0.1783397f,0f),0f).setDelay(0f);
          LeanTween.scale(p8,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
    }
   public void p8click()
    { 
       LeanTween.scale(p8_1,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(p9,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
    }
    public void p9click()
    { 
       LeanTween.scale(p9_1,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(p10,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
    }
      public void p10click()
    { 
       LeanTween.scale(p10_1,new Vector3(0.02031068f,0.04893441f,0f),0.5f).setDelay(0.5f);
    }
    
    
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p7,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p8_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p9_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p10,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p10_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(l1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l1_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l2_2,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(l3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(l3_3,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(l4,new Vector3(0f,0f,0f),0f);


     }
     /**********************************************************************************************/
    
     public void arabAblueColor()
     {
        LeanTween.scale(b1,new Vector3(0.03256369f,0.05640326f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03246206f,0.06600519f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.1909645f,0.4391198f,0f),0f).setDelay(0f);
          LeanTween.scale(bl1_1,new Vector3(0.09220267f,0.2158859f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.02887884f,0.06717268f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(b4,new Vector3(0.03551386f,0.0801665f,0f),0f).setDelay(0f);
    }
       public void b4click()
    {     
          LeanTween.scale(bl2,new Vector3(0.208766f,0.4573975f,0f),0f).setDelay(0f);
          LeanTween.scale(bl2_2,new Vector3(0.09604046f,0.2360106f,0f),0f).setDelay(0f);
          LeanTween.scale(b5,new Vector3(0.03356787f,0.07047608f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {     
          LeanTween.scale(b6,new Vector3(0.0349736f,0.08046474f,0f),0f).setDelay(0f);
    }
      public void b6click()
    {     
          LeanTween.scale(bl3,new Vector3(0.1988187f,0.41004f,0f),0f).setDelay(0f);
           LeanTween.scale(bl3_3,new Vector3(0.4662928f,0.3225315f,0f),0f).setDelay(0f);
          LeanTween.scale(b7,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
     public void b7click()
    {     
          LeanTween.scale(bl4,new Vector3(0.4459218f,0.2586704f,0f),0f).setDelay(0f);
      LeanTween.scale(b8,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
   public void b8click()
    { 
       LeanTween.scale(b8_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(b9,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
    public void b9click()
    { 
       LeanTween.scale(b9_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(b10,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
      public void b10click()
    { 
       LeanTween.scale(b10_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
   
    
    
       public void bbRemoveAll()
     {
        LeanTween.scale(b1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b7,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(b8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b8_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b9_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b10,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(b10_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(bl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl1_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl2_2,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(bl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(bl3_3,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(bl4,new Vector3(0f,0f,0f),0f);


     }

     /************************************************************************************/
     public void arabAyellowColor()
        {
        LeanTween.scale(y1,new Vector3(0.03256369f,0.05640326f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03246206f,0.06600519f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.1909645f,0.4391198f,0f),0f).setDelay(0f);
          LeanTween.scale(yl1_1,new Vector3(0.09220267f,0.2158859f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.02887884f,0.06717268f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(y4,new Vector3(0.03551386f,0.0801665f,0f),0f).setDelay(0f);
    }
       public void y4click()
    {     
          LeanTween.scale(yl2,new Vector3(0.208766f,0.4573975f,0f),0f).setDelay(0f);
          LeanTween.scale(yl2_2,new Vector3(0.09604046f,0.2360106f,0f),0f).setDelay(0f);
          LeanTween.scale(y5,new Vector3(0.03356787f,0.07047608f,0f),0.5f).setDelay(0.5f);
    }
    public void y5click()
    {     
          LeanTween.scale(y6,new Vector3(0.0349736f,0.08046474f,0f),0f).setDelay(0f);
    }
      public void y6click()
    {     
          LeanTween.scale(yl3,new Vector3(0.1988187f,0.41004f,0f),0f).setDelay(0f);
           LeanTween.scale(yl3_3,new Vector3(0.4662928f,0.3225315f,0f),0f).setDelay(0f);
          LeanTween.scale(y7,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
     public void y7click()
    {     
          LeanTween.scale(yl4,new Vector3(0.4459218f,0.2586704f,0f),0f).setDelay(0f);
     LeanTween.scale(y8,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
   public void y8click()
    { 
       LeanTween.scale(y8_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(y9,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
    public void y9click()
    { 
       LeanTween.scale(y9_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
        LeanTween.scale(y10,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
      public void y10click()
    { 
       LeanTween.scale(y10_1,new Vector3(0.0358226f,0.07424275f,0f),0.5f).setDelay(0.5f);
    }
   
    
    
       public void yyRemoveAll()
     {
        LeanTween.scale(y1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y4,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y5,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y6,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y7,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(y8,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y8_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y9,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y9_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y10,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(y10_1,new Vector3(0f,0f,0f),0f);
         
         LeanTween.scale(yl1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl1_1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl2_2,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(yl3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(yl3_3,new Vector3(0f,0f,0f),0f);
          LeanTween.scale(yl4,new Vector3(0f,0f,0f),0f);


     }

}
