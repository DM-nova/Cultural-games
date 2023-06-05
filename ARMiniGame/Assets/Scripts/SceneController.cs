using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{  public AudioSource audio;
   
   public AudioSource wolf;
   public AudioSource tiger;
   public AudioSource bear;



    public void MainMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void ARScene()
    {   
        SceneManager.LoadScene(1);
    }
    public void QuitApp()
    {  
        Application.Quit();
    }

    public void StartButton()
    {
        audio.Play();
    }
    public void StartWolf()
    {
        wolf.Play();
    }
    public void StartBear()
    {
        bear.Play();
    }
    public void StartTiger()
    {
        tiger.Play();
    }
    
     
    
    
    
}
