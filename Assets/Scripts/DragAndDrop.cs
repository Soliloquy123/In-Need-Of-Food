
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
    public GameObject itemsSlot4;

    public GameObject itemsSlot5;

    public GameObject itemsSlot6;

    public GameObject itemsSlot7;

    public GameObject itemsSlot8;

    public GameObject itemsSlot9;



    bool itemSlot1Check = false;
    bool itemSlot2Check = false;
    bool itemSlot3Check = false;
    bool itemSlot4Check = false;
    bool itemSlot5Check = false;
    bool itemSlot6Check = false;
    bool itemSlot7Check = false;
    bool itemSlot8Check = false;
    bool itemSlot9Check = false;




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
            } 
            else if (ItemSlotManager.itemSlot4Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot4.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot4Check = true;
                Debug.Log("OnStuck4");
            } 

            else if (ItemSlotManager.itemSlot5Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot5.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot5Check = true;
                Debug.Log("OnStuck5");
            } 

            else if (ItemSlotManager.itemSlot6Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot6.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot6Check = true;
                Debug.Log("OnStuck6");
            } 

            else if (ItemSlotManager.itemSlot7Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot7.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot7Check = true;
                Debug.Log("OnStuck7");
            } 

            else if (ItemSlotManager.itemSlot8Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot8.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot8Check = true;
                Debug.Log("OnStuck8");
            } 

            else if (ItemSlotManager.itemSlot9Check == false)
            {
                GetComponent<RectTransform>().position = itemsSlot9.GetComponent<RectTransform>().position;
                ItemSlotManager.itemSlot9Check = true;
                Debug.Log("OnStuck9");
            } 
            
            
            else
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

