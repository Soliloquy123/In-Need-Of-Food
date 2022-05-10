using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    bool dialoguePanel = false;

    private bool npcInRange;
    private void Awake()
    {
        npcInRange = true;
        visualCue.SetActive(true);
    }

public void BellRung()
    {
        if (npcInRange)

        {
            visualCue.SetActive(true);
            
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialoguePanel = true;
                
            }
        }
       
        else
        {
            visualCue.SetActive(true);
        }

       // if (Input.GetKeyDown(KeyCode.B))
       // {
      //      dialoguePanel = true;
     //   }

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
