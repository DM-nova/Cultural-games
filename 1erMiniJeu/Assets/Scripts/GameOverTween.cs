using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTween : MonoBehaviour
{  
    [SerializeField] GameObject colorWheel2, title2, mainBox2, HomeButton2, ReplayButton2, NextLevelButton2, cryingFace, textZones2, notifbox , notifbutton;
    [SerializeField] AudioSource gameoverSound, speedup;
    public ColorsManager FixedColors;
    void Start()
    {
       //head2();
        FixedColors= GameObject.FindObjectOfType<ColorsManager>();
    }

    void Update()
    {}
    

    public void head2()
    {   
         
         LeanTween.rotateAround(colorWheel2,Vector3.forward, -360,5f).setDelay(0f).setLoopClamp();
        LeanTween.scale(title2,new Vector3(2.03236f,1.288673f,1f),0.5f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic); 
        LeanTween.moveLocal(title2, new Vector3(0f,128f,0f),.5f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic); 
        LeanTween.scale(title2, new Vector3(1.816955f,1.15182f,1f),0.5f).setDelay(0.1f).setEase(LeanTweenType.easeInOutCubic).setOnComplete(gameOver);
    }

    public  void gameOver()
    {  
       LeanTween.moveLocal(mainBox2,new Vector3(0f,-22f,0f),0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(CryingFace);
       LeanTween.scale(HomeButton2,new Vector3(0.8f,0.8f,1f),2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
       LeanTween.scale(ReplayButton2,new Vector3(0.8f,0.8f,1f),2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
       LeanTween.scale(NextLevelButton2,new Vector3(1f,0.8f,1f),2f).setDelay(.10f).setEase(LeanTweenType.easeOutElastic);
     }

    public void CryingFace()
    {  
       gameoverSound.Play();
       LeanTween.scale(cryingFace, new Vector3(0.828405f,0.6523689f,1f),2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
       LeanTween.scale(textZones2, new Vector3(1.794375f,0.7978125f,1f),2f).setDelay(0f).setEase(LeanTweenType.easeOutElastic).setOnComplete(speedUp);
    }
    public void speedUp()
    {
        speedup.Play();
    }

    public void notifPopup()
    {
        LeanTween.scale(notifbox, new Vector3(0.2299763f,0.1226275f,1f),0f);
        LeanTween.scale(notifbutton, new Vector3(0.2035895f,0.5141546f,1f),0f);

    }
    public void closeNotif()
    {
          LeanTween.scale(notifbox, new Vector3(0f,0f,0f),0f);
        LeanTween.scale(notifbutton, new Vector3(0f,0f,0f),0f);
    }

}
