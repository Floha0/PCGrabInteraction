using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    
    private Ray ray;
    private RaycastHit hit;
    
    private bool canGrab = true;
    
    private CustomInput input = null;

    private float inputValue;


    private void Awake()
    {
        input = new CustomInput();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void Update()
    {
        inputValue = input.RightHandInteractions.Grab.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        Detect();
    }

    private void Detect()
    {
        if (inputValue > 0.1f && canGrab)
        {
            ray = new Ray(this.transform.position, this.transform.forward);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Grabable"))
                {
                    hit.collider.gameObject.GetComponent<Grab>().grabbing = true;
                    
                    hit.collider.gameObject.GetComponent<Grab>().attachedObject = this.gameObject;
                    canGrab = false;

                }
            }
        }
        
    }

    

    
}
