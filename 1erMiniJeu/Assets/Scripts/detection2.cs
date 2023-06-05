using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detection2 : MonoBehaviour
{   
     public TimeSpentCounter time;
     public ColorsManager go;
     public ColorsManager animateSpawner;
     public ColorsManager colorsToSpawn;
     public AudioSource collisionSound;
    
    void Start()
    {   
        time = GameObject.FindObjectOfType<TimeSpentCounter>();
        colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
        go = GameObject.FindObjectOfType<ColorsManager>();
        animateSpawner = GameObject.FindObjectOfType<ColorsManager>();
    }

    void Update()
    {
        
    } 
    
   IEnumerator Waiting(GameObject thiss, Collider2D otherr)
   {
       LeanTween.scale(thiss.gameObject, new Vector3(0f,0f,0f),.3f).setEase(LeanTweenType.easeInOutCubic);
       LeanTween.scale(otherr.gameObject, new Vector3(0f,0f,0f),1.5f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
       yield return new WaitForSeconds(2);
       Destroy (otherr.gameObject);
       colorsToSpawn.RemoveColor(thiss.name);
       Destroy(thiss.gameObject);
       animateSpawner.SpawnerAnimation();
       go.ColorSpawn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {  
         if( other.CompareTag("a") && this.CompareTag("a"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("b") && this.CompareTag("b"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("c") && this.CompareTag("c"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("d") && this.CompareTag("d"))
        {  
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("e") && this.CompareTag("e"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("f") && this.CompareTag("f"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("g") && this.CompareTag("g"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("h") && this.CompareTag("h"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("i") && this.CompareTag("i"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("j") && this.CompareTag("j"))
        {  
            StartCoroutine(Waiting(this.gameObject,other));
        }
        
       
    }}

