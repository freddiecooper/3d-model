﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class robotmove : MonoBehaviour
{

    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 Velocity = rb.velocity;
        
        if(Input.GetKey("left"))
        {
            Velocity.x=13;
            anim.SetBool("walk", true);
            transfrom.rotation = Quternion.Euler(0,270,0);
        }
        else if(Input.GetKey("right"))
        {
            Velocity.x=-13;
            anim.SetBool("walk", true);
            transfrom.rotation = Quternion.Euler(0,90,0);
        }
        else if(Input.GetKey("up"))
        {
            Velocity.z=-13;
            anim.SetBool("walk", true);
            transfrom.rotation = Quternion.Euler(0,180,0);
        }
        else if(Input.GetKey("down"))
        {
            Velocity.z=13;
            anim.SetBool("walk", true);
            transfrom.rotation = Quternion.Euler(0,0,0);
        }
        else
        {
            Velocity.x=0;
            Velocity.z=0;
            anim.SetBool("walk", false);
            anim.SetBool("idle", false);
        }

        
        //else
        //{
            //Velocity.z=0;
        //}

        rb.velocity = Velocity;
    }
}
