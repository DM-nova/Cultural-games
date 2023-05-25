using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{   
    public AudioSource audio;

    public void MenuScene()
    {
       SceneManager.LoadScene(0);
    }
    public void ColorsFirstLevel()
    {   
       SceneManager.LoadScene(1);
    }
    public void ColorsSecondLevel()
    {  
       SceneManager.LoadScene(2);
    }
    public void LettersFirstLevel()
    {   
       SceneManager.LoadScene(3);
    }
    

}
