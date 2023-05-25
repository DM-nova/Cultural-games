using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tween : MonoBehaviour
{
    public float fadeTime =2f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;
    public AudioSource letterPop;
    public List<GameObject> items=new List<GameObject>();

    //public AudioSource abcd;
    void Start()
    {  
        PanelFadeIn();

    }
    public void ReadAlphabets()
    {
       //StartCoroutine("ReadAlphabetsCoroutine");
    }
    public void PanelFadeIn()
    {
        canvasGroup.alpha=0;
        rectTransform.transform.localPosition =new Vector3(0f,-1000f,0f);
        rectTransform.DOAnchorPos(new Vector2(0f,-55f),fadeTime,false).SetEase(Ease.OutElastic);
        canvasGroup.DOFade(1,fadeTime);
        StartCoroutine("ItemsAnimation");
    }
    public void PanelFadeOut()
    {
        canvasGroup.alpha=1;
        rectTransform.transform.localPosition =new Vector3(0f,-53f,0f);
        rectTransform.DOAnchorPos(new Vector2(0f,-1000f),fadeTime,false).SetEase(Ease.InOutQuint);
        canvasGroup.DOFade(0,fadeTime);
        
    }

    
    IEnumerator ItemsAnimation()
    {
        foreach(var item in items)
        {
            item.transform.localScale = Vector3.zero;

        }
        foreach(var item in items)
        {   
            yield return new WaitForSeconds(0.2f);
            item.transform.DOScale(1.35f,fadeTime).SetEase(Ease.OutBounce);
            letterPop.Play();
            yield return new WaitForSeconds(0.01f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
