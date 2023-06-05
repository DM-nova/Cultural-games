using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void writeA()
    {   
        SceneManager.LoadScene(3);
    }
public void writeB()
    {   
        SceneManager.LoadScene(4);
    }
public void mainMenu()
    {   
        SceneManager.LoadScene(3);
    }
    public void FirstMenu()
    {   
        SceneManager.LoadScene(0);
    }
     public void EnglishMenu()
    {   
        SceneManager.LoadScene(1);
    }
    public void aArabic()
    {   
        SceneManager.LoadScene(5);
    }
    public void arabicMenu()
    {   
        SceneManager.LoadScene(4);
    }


}
