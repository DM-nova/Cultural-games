using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{  
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    { 
    }

    void OnCollisionEnter2D(Collision2D coll)
    {  
        if(coll.gameObject.tag == "Border")
        {
            Debug.Log(" border hit");
            //this.isStatic = true;
        }
    }
   

}
