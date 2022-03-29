using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    int position = 0;

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
        }
        else if (position == 1)
        {
            transform.position = new Vector3(31.52f, 0f, -10f);
        }
        else if (position == 2)
        {
            transform.position = new Vector3(58.47f, 0f, -10f);
        }

        
        
    }

    public void NextScreen()
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

    public void BackScreen()
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
