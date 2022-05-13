
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    public GameObject itemSlot;
    public GameObject itemSlot2;
    public GameObject itemSlot3;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
       canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
         canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        rectTransform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rectTransform.position = new Vector3(rectTransform.position.x, rectTransform.position.y, -8f); ;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null)
        {
            Debug.Log("Getting Stuck");
            GetComponent<RectTransform>().position = itemSlot.GetComponent<RectTransform>().position;
            GetComponent<RectTransform>().position = itemSlot.GetComponent<RectTransform>().position;
            GetComponent<RectTransform>().position = itemSlot3.GetComponent<RectTransform>().position;
            Debug.Log("OnStuck");
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}

