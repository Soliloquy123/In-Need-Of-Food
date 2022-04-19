using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public GameObject Bell;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject destination;
    bool bells = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b") && !Bell)
        {
            bells = true;
            NPC1.transform.position = destination.transform.position;
        }
    }

    public void RingBell()
    {
        
    }
}
