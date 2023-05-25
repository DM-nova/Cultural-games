using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   
   public AudioSource ButtonClick;

  public void MainMenu()
    {
         SceneManager.LoadScene(0);
    }
    public void ArabicAlphabets()
    {   
        SceneManager.LoadScene(1);
    }
    public void FrenchAlphabets()
    {   
        SceneManager.LoadScene(2);
    }
    public void QuitApp()
    {  
        Application.Quit();
    }


   public void Back()
   {
        SceneManager.LoadScene(0);

   }
   public void QuitGame()
   {
    Application.Quit();
   }

   public void StartButton()
    {
        ButtonClick.Play();
    }
}
