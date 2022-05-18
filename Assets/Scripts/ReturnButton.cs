using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ReturnButton : MonoBehaviour
{

    public void ReturnItems()
    {
        GetComponent<RectTransform>().position = ItemSlotManager.lastPos;
        Debug.Log("Sent Back");
    }
}

