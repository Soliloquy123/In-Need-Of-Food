
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    /*public GameObject itemSlot;
    public GameObject itemSlot2;
    public GameObject itemSlot3;

    bool itemSlot1Check = false;
    bool itemSlot2Check = false;
    bool itemSlot3Check = false;*/


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

        ItemSlotManager.lastPos = transform.position;
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
        //IF DRAG ENDS ON A TRAY
        //GET THE TRAYS ITEM SLOT MANAGER
        //TELL THE MANAGER THAT THIS ITEM HAS BEEN DROPPED ON THE TRAY




        /*Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null && (itemSlot1Check = false))
        {
            Debug.Log("Getting Stuck");
            GetComponent<RectTransform>().position = itemSlot.GetComponent<RectTransform>().position;
            //itemSlot1Check = true;
           // GetComponent<RectTransform>().position = itemSlot2.GetComponent<RectTransform>().position;
           // GetComponent<RectTransform>().position = itemSlot3.GetComponent<RectTransform>().position;
            Debug.Log("OnStuck");
        }
        //else itemSlot1Check = true;
            //GetComponent<RectTransform>().position = itemSlot2.GetComponent<RectTransform>().position;
        */
    }

    /*public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null)
        {
            Debug.Log("Getting Stuck");
            GetComponent<RectTransform>().position = itemSlot.GetComponent<RectTransform>().position;
            itemSlot1Check = true;
            GetComponent<RectTransform>().position = itemSlot2.GetComponent<RectTransform>().position;
            GetComponent<RectTransform>().position = itemSlot3.GetComponent<RectTransform>().position;
            Debug.Log("OnStuck");
        }
        //else itemSlot1Check = true;
        //GetComponent<RectTransform>().position = itemSlot2.GetComponent<RectTransform>().position;

    }*/

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}

