using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellSound : MonoBehaviour
{
    public AudioSource audioSource;

    Void Start()
    {
        audioSource.BellSound();
    }
}

{
    void Update()
    {
        if (Input.GetKeyDown("b") && !Bell)
    }
}
