using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotManager : MonoBehaviour
{
    public static bool itemSlot1Check = false;
    public static bool itemSlot2Check = false;
    public static bool itemSlot3Check = false;

    public static Vector3 lastPos;

    public GameObject[] items;

    public void ReturnItems()
    {
        foreach (GameObject item in items)
        {
            item.transform.position = item.GetComponent<DragAndDrop>().startPos;
        }

        //GetComponent<RectTransform>().position = ItemSlotManager.lastPos;
        Debug.Log("Sent Back");
    }
}

