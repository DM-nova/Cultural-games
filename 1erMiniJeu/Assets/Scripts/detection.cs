using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detection : MonoBehaviour
{   
    public Scoring score;
    public ColorsManager go;
    public ColorsManager colorsToSpawn;
    public List<GameObject> listcolorsToSpawn = new List<GameObject>();
    void Start()
    {   colorsToSpawn= GameObject.FindObjectOfType<ColorsManager>();
        go = GameObject.FindObjectOfType<ColorsManager>();
       score = GameObject.FindObjectOfType<Scoring>();
       listcolorsToSpawn = colorsToSpawn.colorsToSpawn;       
    }

    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {  
        
        //Debug.Log("Triggered");
        if( other.CompareTag("Rouge") && this.CompareTag("Rouge"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("red");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
            go.ColorSpawn();
        }
        else if (other.CompareTag("Jaune") && this.CompareTag("Jaune"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("yellow");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
            go.ColorSpawn();

        }
        else if (other.CompareTag("Vert") && this.CompareTag("Vert"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("green");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
             go.ColorSpawn();

        }
        else if (other.CompareTag("Bleu") && this.CompareTag("Bleu"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("blue");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
            go.ColorSpawn();

        }
        else if (other.CompareTag("Rose") && this.CompareTag("Rose"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("pink");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
            go.ColorSpawn();

        }
        else if (other.CompareTag("Blanc") && this.CompareTag("Blanc"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("blanc");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
             go.ColorSpawn();

        }
        else if (other.CompareTag("Orangé") && this.CompareTag("Orangé"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("orange");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
             go.ColorSpawn();

        }
        else if (other.CompareTag("Violet") && this.CompareTag("Violet"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("purple");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
             go.ColorSpawn();

        }
        else if (other.CompareTag("Noire") && this.CompareTag("Noire"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("black");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
            go.ColorSpawn();

        }
        else if (other.CompareTag("Marron") && this.CompareTag("Marron"))
        {   score.AddScore(1);
            int indexOfYourGameObject = listcolorsToSpawn.IndexOf(this.gameObject);
            Debug.Log("brown");
            Destroy (other.gameObject);
            Destroy(this.gameObject);
            colorsToSpawn.RemoveColor(indexOfYourGameObject);
             go.ColorSpawn();

        }
        else 
        {
            SceneManager.LoadScene(1);
        }
        

        
        
    }
    }

