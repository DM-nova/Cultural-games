using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{  
    [SerializeField]  private AudioSource hit;
    
    void Start()
    {
      
    }
    void Update()
    {}

    void OnCollisionEnter2D(Collision2D coll)
    {  
        if(coll.gameObject.tag == "Border")
          {  hit.Play();
             LeanTween.cancel(gameObject);
             LeanTween.moveY(gameObject,transform.position.y -0.5f, 0.5f).setEaseShake();
             Debug.Log(" border hit");
          }
    }
}