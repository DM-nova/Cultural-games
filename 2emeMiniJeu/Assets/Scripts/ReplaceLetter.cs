using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplaceLetter : MonoBehaviour
{  //public Button NextButton;
   //public  Button btn ;
   //public List<GameObject> alphabets = new List<GameObject>();
   public GameObject[] alphabets;
   GameObject newObj;
   public bool used = false;
  public int unt;

   void Start()
    {  
      //btn = NextButton.GetComponent<Button>();
		  //btn.onClick.AddListener(Update);

      GameObject Alphabets = GameObject.Find("Alphabets");
      newObj =Instantiate(alphabets[0],transform.position, Quaternion.identity);
      newObj.transform.parent =Alphabets.transform;
      newObj.transform.localScale = new Vector3(1, 1,0);
    }


   /* void Update()
    { 
      if(!used && Input.GetMouseButtonDown(0) )  
      { 
        used =true;
        badal(unt);
        Debug.Log("Replaced");
        
      }
    }*/
    void badal()
    { 
      for(int i=0;i<alphabets.Length;i++)
      {  if (i==unt) {
        GameObject Obj= alphabets[i];

       GameObject Alphabets = GameObject.Find("Alphabets");
        newObj =Instantiate(alphabets[i+1],/*alphabets[i].*/transform.position, Quaternion.identity);
        newObj.transform.parent =Alphabets.transform;
        
        newObj.transform.localScale = new Vector3(1, 1,0);
        string s = alphabets[i].name + "(Clone)";
        
      //GameObject.Find(s).transform.localScale = new Vector3(14, 13,33);

        Destroy(GameObject.Find(s));
        
        //used =false;
      }
      }
    }


public void badalplus()
    {      
      if (unt==alphabets.Length-1)
          unt=0;
      else
        badal();
      unt++;
    }
  public void badalmoin()
    {      
      if (unt==0)
          unt=alphabets.Length-1;
      else
        badal();
      unt--;    
    }
}