using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;
using UnityEngine.Analytics;

public class ScenesManager : MonoBehaviour
{   
    public AudioSource audio;
    int chosenLevel = 1;

    public void MenuScene()
    {
       SceneManager.LoadScene("MenuJEU1");
    }
    public void ColorsFirstLevel()
    {   
       SceneManager.LoadScene("ColorsFirstLevel");
    }
    public void ColorsSecondLevel()
    {  
       SceneManager.LoadScene("ColorsSecondLevel");
    }
    public void LettersFirstLevel()
    {   
       SceneManager.LoadScene("LettersFirstLevel");
    }
     public void LettersSecondLevel()
    {   
       SceneManager.LoadScene("LettersSecondLevel");
    }
    

}
