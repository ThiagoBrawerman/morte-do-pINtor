using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;
    // Start is called before the first frame update
    void Awake()
    {
        current = this;
    }

    public event Action onPaintingTriggerEnter;

    public void PaintingTriggerEnter() 
    {
        if(onPaintingTriggerEnter != null) 
        {
            onPaintingTriggerEnter();
        }
    }
}
