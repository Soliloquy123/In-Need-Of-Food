using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private Vector3 dragOffSet;
    private Camera cam;
    [SerializeField] private float speed = 10;

    void Awake()
    {
        cam = Camera.main;
    }

     /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        dragOffSet = transform.position - GetMousePos();
    }


     void OnMouseDrag() 
    {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + dragOffSet, speed * Time.deltaTime) ;
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
