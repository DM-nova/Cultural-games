using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swiper : MonoBehaviour , IDragHandler, IEndDragHandler
{   private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    // Start is called before the first frame update
    
    void Start()
    {
        panelLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 public void OnDrag(PointerEventData data){
        float difference =data.pressPosition.x -data.position.x;
        transform.position =panelLocation - new Vector3(difference, 0,0);

    }
    public void OnEndDrag(PointerEventData data){
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if(Mathf.Abs(percentage) >= percentThreshold){
            Vector3 newLocation = panelLocation;

            if(percentage > 0){
                newLocation += new Vector3(-Screen.width ,0,0);
            }
            else if( percentage < 0){
                newLocation += new Vector3(Screen.width , 0,0);
            }
            StartCoroutine(smoothMove(transform.position ,newLocation ,easing));
            panelLocation = newLocation;

        }
        else{
            StartCoroutine(smoothMove(transform.position,panelLocation, easing));
        }
    }
    IEnumerator smoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t =0f;
        while( t<=1.0){
            t += Time.deltaTime / seconds;
            transform.position =Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f ,1f,t));
            yield return null;
        }
    }
}
