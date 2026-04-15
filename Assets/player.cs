using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{

    public PlayerPhysics ballPhys;
    float pwrMax = 10f;
    float pwr = 1f;
    public float playerSize = 1;

    bool isDragged;

       
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        transform.localScale = (Vector2.one * playerSize);
        
    }

    private void PlayerInput()
    {
        //getting mouse position
        Vector2 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //distance float is equal to the difference between mouse position and the position of the cell
        float distance = Vector2.Distance(transform.position, inputPos);

        if (Input.GetMouseButtonDown(0) && distance <= 1f) DragStart();
        if (Input.GetMouseButtonUp(0) && isDragged == true) DragRelease(inputPos);
        if (Input.GetMouseButton(0)) DragChange();
    }

    private void DragStart()
    {
        isDragged = true;

        Debug.Log("start drag");

        return;

    }

    private void DragChange()
    {
        
    }

    private void DragRelease(Vector2 pos)
    {
        Debug.Log("release drag");
        float distance = Vector2.Distance((Vector2)transform.position, pos);  
        ballPhys.velocity = (Vector2)transform.position - pos;
        ballPhys.accel = distance * pwr;
        isDragged = false;


        return;
    }


}
