using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotManager : MonoBehaviour
{
    public static bool itemSlot1Check = false;
    public static bool itemSlot2Check = false;
    public static bool itemSlot3Check = false;
    public static bool itemSlot4Check = false;
    public static bool itemSlot5Check = false;
    public static bool itemSlot6Check = false;
    public static bool itemSlot7Check = false;
    public static bool itemSlot8Check = false;
    public static bool itemSlot9Check = false;



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

