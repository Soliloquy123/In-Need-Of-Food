using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform RectTransform;
    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventdata)
    {
        Debug.Log("OnDrag");
    }
     public void OnEndDrag(PointerEventData eventdata)
    {
        Debug.Log("OnEndDrag");
    }
    public void OnPointerDown(PointerEventData eventdata)
    {
        Debug.Log("OnPointerDown");
    }
}

