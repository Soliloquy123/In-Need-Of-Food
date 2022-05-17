using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotManager : MonoBehaviour
{
    public GameObject itemSlot;
    public GameObject itemSlot2;
    public GameObject itemSlot3;

    bool itemSlot1Check = false;
    bool itemSlot2Check = false;
    bool itemSlot3Check = false;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    void Start()
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null && (itemSlot1Check = false))
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
        
    }

}
