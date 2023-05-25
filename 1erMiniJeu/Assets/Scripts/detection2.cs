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
         if( other.CompareTag("Rouge") && this.CompareTag("Rouge"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Jaune") && this.CompareTag("Jaune"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Vert") && this.CompareTag("Vert"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Bleu") && this.CompareTag("Bleu"))
        {  
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Rose") && this.CompareTag("Rose"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Blanc") && this.CompareTag("Blanc"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Orangé") && this.CompareTag("Orangé"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Violet") && this.CompareTag("Violet"))
        {   
           StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Marron") && this.CompareTag("Marron"))
        {   
            StartCoroutine(Waiting(this.gameObject,other));
        }
        else if (other.CompareTag("Noire") && this.CompareTag("Noire"))
        {  
            StartCoroutine(Waiting(this.gameObject,other));
        }
        
       
    }}

