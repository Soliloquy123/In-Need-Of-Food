using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Ending : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI endingLine;

    int lineToShow = 0;

    public string[] lines;
    public TMP_Text endingLine;

    public void NextLine()
    {
        lineToShow++;

        endingLine.text = lines[lineToShow];
    }

}
