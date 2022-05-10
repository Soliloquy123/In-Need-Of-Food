using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject bell;
    public GameObject dialogPanel;
    public GameObject NPCText;
    public GameObject controls;

    public GameObject bellInstructions;

    public GameObject arrowInstructions;

    public GameObject dialogInstructions;

    public GameObject foodInstructions;

    int position = 0;

    public GameObject bellPressed;

    public GameObject Bell;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject destination;
    bool bells = false;

    public AudioSource audioSource;

    bool bellPressed1 = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (position == 0)
        {
            transform.position = new Vector3(0f, 0f, -10f);
            bell.SetActive(true);
            dialogPanel.SetActive(false);
            NPCText.SetActive(false);
            controls.SetActive(false);
            arrowInstructions.SetActive(true);
            bellInstructions.SetActive(true);
            dialogInstructions.SetActive(false);
            foodInstructions.SetActive(true);
        }
        else if (position == 1)
        {
            transform.position = new Vector3(31.52f, 0f, -10f);
            bell.SetActive(false);
            dialogPanel.SetActive(true);
            controls.SetActive(true);
            NPCText.SetActive(true);
            arrowInstructions.SetActive(false);
            bellInstructions.SetActive(false);
            dialogInstructions.SetActive(true);
            foodInstructions.SetActive(false);
        }
        else if (position == 2)
        {
            transform.position = new Vector3(58.47f, 0f, -10f);
            bell.SetActive(false);
            dialogPanel.SetActive(false);
            NPCText.SetActive(false);
            controls.SetActive(false);
            arrowInstructions.SetActive(false);
            bellInstructions.SetActive(false);
            dialogInstructions.SetActive(false);
            foodInstructions.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            bellPressed1 = true;
        }
        
    }

    public void NextScreen()
    {
        if (bellPressed1 == true)
        {
            if (position == 2)
            {
                position = 0;
            }
            else
            {
                position++;
            }
        }
    }

    public void BackScreen()
    {
        if (bellPressed1 == true)
        {
            if (position == 0)
            {
                position = 2;
            }
            else
            {
                position--;
            }
        }

    }
    public void RingBell()
    {
        // when B is pressed the first npc spawns in the seconnd background
        if (!bells)
        {

            bells = true;
            NPC1.transform.position = destination.transform.position;

            audioSource.Play();


        }
    }


}

