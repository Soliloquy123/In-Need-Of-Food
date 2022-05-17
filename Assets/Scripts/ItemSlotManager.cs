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

    public static Vector3 lastPos;

    public void OnItemDrop(GameObject item)
    {
        if (itemSlot1Check == false)
        {
            item.transform.position = itemSlot.transform.position;
            itemSlot1Check = true;
        } 
        else if (itemSlot2Check == false)
        {
            item.transform.position = itemSlot2.transform.position;
            itemSlot2Check = true;
        } 
        else if (itemSlot3Check == false)
        {
            item.transform.position = itemSlot3.transform.position;
            itemSlot3Check = true;
        } 
        else
        {
            item.transform.position = lastPos;
        }
    }

}
