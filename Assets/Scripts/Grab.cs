using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    
    [NonSerialized]
    public bool grabbing;

    private float grabTime;
    
    [SerializeField]
    private float grabSpeed = 1.0f;
    
    [NonSerialized]
    public GameObject attachedObject;
    
    [SerializeField]
    private float grabOffset = 2.0f;

    
    private void FixedUpdate()
    {
        if (grabbing)
        {
            if (grabTime < 1.0f)
            {
                grabTime += Time.fixedDeltaTime * grabSpeed;
            }
            else if (grabTime > 1.0f)
            {
                grabTime = 1.0f;
            }
            
            GrabObject();
        }
    }

    public void GrabObject()
    {
        Vector3 grabPoint = attachedObject.transform.forward * grabOffset + attachedObject.transform.position;
        transform.position = Vector3.Lerp(transform.position, grabPoint, grabTime);
    }
}