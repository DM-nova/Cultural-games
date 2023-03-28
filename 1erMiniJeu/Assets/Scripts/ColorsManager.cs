using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsManager : MonoBehaviour
{    public detection other;
    public List<GameObject> colorsToSpawn = new List<GameObject>();
     public bool isRandomized;

     void Start()
    {   other= GameObject.FindObjectOfType<detection>();
        ColorSpawn();
    }
 
    public void ColorSpawn()
    {
        int index= isRandomized ?Random.Range(0, colorsToSpawn.Count):0;
        
        Instantiate(colorsToSpawn[index], transform.position, transform.rotation);
        
    }
    public void RemoveColor(int indice)
    {    
        colorsToSpawn.RemoveAt(indice);

       /*for (int i =0; i<= colorsToSpawn.Count; i++){
                if(other.CompareTag("Rouge") && colorsToSpawn[i].CompareTag("Rouge")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Jaune") && colorsToSpawn[i].CompareTag("Jaune")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Vert") && colorsToSpawn[i].CompareTag("Vert")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Bleu") && colorsToSpawn[i].CompareTag("Bleu")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Rose") && colorsToSpawn[i].CompareTag("Rose")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Blanc") && colorsToSpawn[i].CompareTag("Blanc")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Orangé") && colorsToSpawn[i].CompareTag("Orangé")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Noire") && colorsToSpawn[i].CompareTag("Noire")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Marron") && colorsToSpawn[i].CompareTag("Marron")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
                else if(other.CompareTag("Violet") && colorsToSpawn[i].CompareTag("Violet")){
                    colorsToSpawn.Remove(colorsToSpawn[i]);
                }
            }*/
        
    }
}
    
    
