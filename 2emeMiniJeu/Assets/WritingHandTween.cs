using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class WritingHandTween : MonoBehaviour
{
    
    //[SerializeField] GameObject p1,p2,p3,letter,path,mainHandButton;
    [SerializeField] GameObject line1,line2,line3 ,n1,n2,n3,n4, hand1, hand2,hand3,hand4,mainHandButton;
    [SerializeField] AudioSource LineGenerationSound;

    void Start()
    {
      //transform.DOMove(new Vector3(10f,0f,0f),_cycleLength).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
     // LeanTween.moveLocal(t,new Vector3(-6.6f,104.7f,0f),0.7f).setDelay(0f).setEase(LeanTweenType.easeOutElastic).setOnComplete(ahbat);
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    public void RemoveMainHandButton()
    {
        LeanTween.scale(mainHandButton,new Vector3(0f,0f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeInOutCubic).setOnComplete(pt1);
    }

    public void pt1()
    {
          LeanTween.scale(n1,new Vector3(0.5174958f,0.5174958f,0f),1f).setDelay(0.2f);
          LeanTween.scale(hand1,new Vector3(1.704298f,1.704298f,0f),1f).setDelay(0.2f).setOnComplete(pt2);

    }
    public void pt2()
    {
        
          LeanTween.scale(hand1,new Vector3(0f,0f,0f),0f).setDelay(0.2f);
          LeanTween.scale(n2,new Vector3(0.522355f,0.5027667f,0f),1f).setDelay(0.2f);
           LeanTween.scale(hand2,new Vector3(1.704298f,1.704298f,0f),0.7f).setDelay(0.2f);
           LineGenerationSound.Play();
           LeanTween.scale(line1,new Vector3(2.472656f,0.36248f,0f),2f).setDelay(0.2f).setOnComplete(pt3);


    }
    public void pt3()
    {   
        LeanTween.scale(hand2,new Vector3(0f,0f,0f),0f).setDelay(0.2f);
        LeanTween.scale(n3,new Vector3(0.5585217f,0.5794663f,0f),1f).setDelay(0.2f);
         LeanTween.scale(hand3,new Vector3(1.704298f,1.704298f,0f),1f).setDelay(0.2f);
         LineGenerationSound.Play();
          LeanTween.scale(line2,new Vector3(2.777827f,0.40779f,0f),2f).setDelay(0.2f).setOnComplete(pt4);
    }
    public void pt4()
    {   
        LeanTween.scale(hand3,new Vector3(0f,0f,0f),0f).setDelay(0.2f);
        LeanTween.scale(n4,new Vector3(0.5585217f,0.5794663f,0f),1f).setDelay(0.2f);
         LeanTween.scale(hand4,new Vector3(1.704298f,1.704298f,0f),1f).setDelay(0.2f);
         LineGenerationSound.Play();
          LeanTween.scale(line3,new Vector3(2.472656f,0.36248f,0f),2f).setDelay(0f).setOnComplete(removeDemo);
    }
     public void removeDemo()
    {
        LeanTween.scale(hand4,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(n1,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(n2,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(n3,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(n4,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(line1,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(line2,new Vector3(0f,0f,0f),0f);
        LeanTween.scale(line3,new Vector3(0f,0f,0f),0f);

        LeanTween.scale(mainHandButton,new Vector3(0.4407322f,0.9690802f,0f),0f).setDelay(0f).setEase(LeanTweenType.easeInOutCubic);
    }

    
    /*public void makePoint1()
    {    
         LeanTween.scale(path,new Vector3(0.4864608f,0.583753f,0f),0.5f).setDelay(0f);
         LeanTween.scale(p1,new Vector3(1.704298f,1.704298f,0f),0.5f).setDelay(2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(deplacePoint1);
        
    }
    public void deplacePoint1()
    {
        LeanTween.moveLocal(p1,new Vector3(2f,-132f,0f),5f).setOnComplete(deletePoint1);
    }
    public void deletePoint1()
    {
        LeanTween.scale(p1,new Vector3(0f,0f,0f),0f).setDelay(0.2f).setOnComplete(makePoint2);
    }
    public void makePoint2()
    {
       LeanTween.scale(p2,new Vector3(1.704298f,1.704298f,0f),0f).setDelay(0.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(deplacePoint2);
    }
    public void deplacePoint2()
    {
         LeanTween.moveLocal(p2,new Vector3(311f,-130f,0f),5f).setDelay(0.2f).setOnComplete(deletePoint2);
        

    }
    public void deletePoint2()
    {
        LeanTween.scale(p2,new Vector3(0f,0f,0f),0f).setDelay(0.2f).setOnComplete(makePoint3);
    }
    public void makePoint3()
    {
        LeanTween.scale(p3,new Vector3(1.704298f,1.704298f,0f),0f).setDelay(0.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(deplacePoint3);

    }
    public void deplacePoint3()
    {
         LeanTween.moveLocal(p3,new Vector3(257f,-66f),5f).setDelay(0f).setOnComplete(LetterReveal);
    }
    public void LetterReveal()
    {    LeanTween.scale(p3,new Vector3(0f,0f,0f),0f).setDelay(0f);
         LeanTween.scale(path,new Vector3(0f,0f,0f),0f).setDelay(0f);
        LeanTween.scale(letter,new Vector3(0.4968362f,0.7436635f,0f),5f).setDelay(0f).setEase(LeanTweenType.easeOutElastic).setOnComplete(handAgain);

        

    }
    public void handAgain()
    {
         LeanTween.scale(letter,new Vector3(0f,0f,0f),0f).setDelay(0f);
         LeanTween.scale(mainHandButton,new Vector3(0.4407322f,0.9690802f,0f),5f).setEase(LeanTweenType.easeOutElastic);

    }*/

}
