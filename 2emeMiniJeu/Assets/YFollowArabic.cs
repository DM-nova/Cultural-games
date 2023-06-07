using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YFollowArabic : MonoBehaviour 
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
        LeanTween.scale(p1,new Vector3(0.02271387f,0.03884357f,0.5f),0.5f).setDelay(0.5f);
    }
     public void p1click()
    {
          LeanTween.scale(p2,new Vector3(0.02092664f,0.0403145f,0f),0.5f).setDelay(0.5f);
    }
    public void p2click()
    {     
          LeanTween.scale(l1,new Vector3(0.1579351f,0.2065106f,0f),0f).setDelay(0f);
          LeanTween.scale(p3,new Vector3(0.02182735f,0.05568852f,0f),0.5f).setDelay(0.5f);
    }
    public void p3click()
    {     
          LeanTween.scale(l2,new Vector3(0.1371892f,0.3186736f,0f),0f).setDelay(0f);
           LeanTween.scale(p4,new Vector3(0.0221775f,0.0528168f,0f),0.5f).setDelay(0.5f);
    }
    public void p4click()
    {LeanTween.scale(l3,new Vector3(0.1371892f,0.3186736f,0f),0f).setDelay(0f);
LeanTween.scale(p5,new Vector3(0.01786083f,0.04048681f,0f),0.5f).setDelay(0.5f);
    }
    public void p5click()
    {
LeanTween.scale(p5_1,new Vector3(0.01747308f,0.03960786f,0f),0.5f).setDelay(0.5f);
LeanTween.scale(p6,new Vector3(0.01904444f,0.04795687f,0f),0.5f).setDelay(0.5f);
    }
     public void p6click()
    {
LeanTween.scale(p6_1,new Vector3(0.01733908f,0.0393041f,0f),0.5f).setDelay(0.5f);
    }
   
       public void aaRemoveAll()
     {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p2,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p3,new Vector3(0f,0f,0f),0f);
         LeanTween.scale(p4,new Vector3(0f,0f,0f),0f);
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
        LeanTween.scale(b1,new Vector3(0.03833608f,0.06555952f,0.5f),0.5f).setDelay(0.5f);
    }
     public void b1click()
    {
          LeanTween.scale(b2,new Vector3(0.03347084f,064480490.0403145f,0f),0.5f).setDelay(0.5f);
    }
    public void b2click()
    {     
          LeanTween.scale(bl1,new Vector3(0.2432601f,0.3443018f,0f),0f).setDelay(0f);
          LeanTween.scale(b3,new Vector3(0.03540649f,0.09033322f,0f),0.5f).setDelay(0.5f);
    }
    public void b3click()
    {     
          LeanTween.scale(bl2,new Vector3(0.1979813f,0.5332015f,0f),0f).setDelay(0f);
           LeanTween.scale(b4,new Vector3(0.03654963f,0.08704472f,0f),0.5f).setDelay(0.5f);
    }
    public void b4click()
    {LeanTween.scale(bl3,new Vector3(0.2116904f,0.4917307f,0f),0f).setDelay(0f);
LeanTween.scale(b5,new Vector3(0.02935296f,0.06653709f,0f),0.5f).setDelay(0.5f);
    }
    public void b5click()
    {
LeanTween.scale(b5_1,new Vector3(0.02871572f,0.0650926f,0f),0.5f).setDelay(0.5f);
LeanTween.scale(b6,new Vector3(0.03068832f,0.07727798f,0f),0.5f).setDelay(0.5f);
    }
     public void b6click()
    {
LeanTween.scale(b6_1,new Vector3(0.0279403f,0.06333486f,0f),0.5f).setDelay(0.5f);
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
       
     }

     /************************************************************************************/
     public void arabAyellowColor()
     {
        LeanTween.scale(y1,new Vector3(0.03095589f,0.05489657f,0.5f),0.5f).setDelay(0.5f);
    }
     public void y1click()
    {
          LeanTween.scale(y2,new Vector3(0.03227562f,0.06363758f,0f),0.5f).setDelay(0.5f);
    }
    public void y2click()
    {     
          LeanTween.scale(yl1,new Vector3(0.6106862f,0.2717922f,0f),0f).setDelay(0f);
          LeanTween.scale(y3,new Vector3(0.03316578f,0.07349651f,0f),0.5f).setDelay(0.5f);
    }
    public void y3click()
    {     
          LeanTween.scale(yl2,new Vector3(0.5567391f,0.1993216f,0f),0f).setDelay(0f);
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
