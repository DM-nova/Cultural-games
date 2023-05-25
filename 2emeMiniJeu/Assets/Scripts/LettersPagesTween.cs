using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LettersPagesTween : MonoBehaviour
{
     public float fadeTime =2f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;
    //public List<GameObject> items=new List<GameObject>();
    void Start()
    {
        BlueBoardFadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlueBoardFadeIn()
    {
        canvasGroup.alpha=0;
        rectTransform.transform.localPosition =new Vector3(0f,-50f,0f);
        rectTransform.DOAnchorPos(new Vector2(0f,0f),fadeTime,false)/*.SetEase(Ease.OutElastic)*/;
        canvasGroup.DOFade(1,1);
        //StartCoroutine("ItemsAnimation");
    }
}
