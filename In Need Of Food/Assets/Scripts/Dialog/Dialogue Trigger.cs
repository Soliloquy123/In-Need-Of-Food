using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool npcInRange;
    private void Awake()
    {
        npcInRange = false;
        visualCue.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D colliider)
    {
        
    }

    private void OnTriggerExit2D(Collider2D colider)
    {
        
    }
}
