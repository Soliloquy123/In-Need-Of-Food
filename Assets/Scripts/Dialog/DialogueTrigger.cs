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
        npcInRange = false;
        visualCue.SetActive(false);
    }

/*private void Update()
    {
        if (npcInRange)
        {
            visualCue.SetActive(true);
           if (InputManager.GetInstance().GetInteractPressed())
            {
                Debug.Log(inkJSON.text); 
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }*/

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
