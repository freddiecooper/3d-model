﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelboom : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("egg"))
            {
                Destroy(gameObject);
            }
    }
}
