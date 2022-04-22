using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool npcInRange;
    private void Awake()
    {
        npcInRange = true;
        visualCue.SetActive(true);
    }

private void Update()
    {
        if (npcInRange)
        {
            visualCue.SetActive(true);
           if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(inkJSON.text);
            }
        }
       
        else
        {
            visualCue.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPC")
        {
            npcInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPC")
        {
            npcInRange = false;
        }
    }
}
