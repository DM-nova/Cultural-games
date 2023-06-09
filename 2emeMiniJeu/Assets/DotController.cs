using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class DotController : MonoBehaviour, IDragHandler,IPointerClickHandler
{ public LineController line;
public int index;

    public Action<DotController> OnDragEvent;
    public void OnDrag(PointerEventData eventData)
    {
        OnDragEvent?.Invoke(this);
    }

public Action<DotController> OnRightClickEvent;

    public void OnPointerClick(PointerEventData eventData)
    { if(eventData.pointerId == -2) {//right click
        OnRightClickEvent?.Invoke(this);
    }
    
    }

    public void SetLine(LineController line)
    {
        this.line =line;
    }
}

