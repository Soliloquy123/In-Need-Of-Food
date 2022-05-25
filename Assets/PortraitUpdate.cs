using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortraitUpdate : MonoBehaviour
{
    public Image im;

    private void Start()
    {
        im = GetComponent<Image>();
    }

    // Start is called before the first frame update
    void Update()
    {


        if (im.sprite == null)
        {
            DialogueManager dm = FindObjectOfType<DialogueManager>();
            dm.HandleTags(dm.currentStory.currentTags);
        }


    }
}
