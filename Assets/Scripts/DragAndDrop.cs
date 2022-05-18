
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

    bool itemSlot1Check = false;
    bool itemSlot2Check = false;
    bool itemSlot3Check = false;

    public Vector3 startPos;


    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
       canvasGroup = GetComponent<CanvasGroup>();
       
    }

    public void Start()
    {
        startPos = transform.position;
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

    
    
        //IF DRAG ENDS ON A TRAY
        //GET THE TRAYS ITEM SLOT MANAGER
        //TELL THE MANAGER THAT THIS ITEM HAS BEEN DROPPED ON THE TRAY




    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null)
        {
            if (ItemSlotManager.itemSlot1Check == false)
            {
                Debug.Log("Getting Stuck");
                GetComponent<RectTransform>().position = itemSlot.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot1Check = true;
            } 
            else if (ItemSlotManager.itemSlot2Check == false)
            {
                Debug.Log("OnStuck1");
                GetComponent<RectTransform>().position = itemSlot2.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot2Check = true;
            }
            else if (ItemSlotManager.itemSlot3Check == false)
            {
                GetComponent<RectTransform>().position = itemSlot3.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot3Check = true;
                Debug.Log("OnStuck3");
            } else
            {
                GetComponent<RectTransform>().position = ItemSlotManager.lastPos;
            }
        }

    }

     public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}

