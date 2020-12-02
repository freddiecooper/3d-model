using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class robotmove : MonoBehaviour
{
    public Transform handpoint;
    public Rigidbody egg;
    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    public void throwegg()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("throw", true);
            Rigidbody egginstance;
             //Instantiate(handpoint.position, handpoint.rotation)as Rigidbody;
            egginstance = Instantiate(egg, handpoint.position,handpoint.rotation) as Rigidbody;
            egginstance.AddForce(handpoint.forward * 350f);
        }
        else
        {
            anim.SetBool("throw", false);
        }
    }

    void Update()
    {
        Vector3 Velocity = rb.velocity;
        
        if(Input.GetKey("left"))
        {
            Velocity.x=5;
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        else if(Input.GetKey("right"))
        {
            Velocity.x=-5;
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            transform.rotation = Quaternion.Euler(0,270,0);
        }
        else if(Input.GetKey("up"))
        {
            Velocity.z=-5;
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if(Input.GetKey("down"))
        {
            Velocity.z=5;
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else
        {
            Velocity.x=0;
            Velocity.z=0;
            anim.SetBool("walk", false);
            anim.SetBool("idle", true);
        }

        if(Velocity.y == 0)
        {
            if(Input.GetKey("space"))
            {
                Velocity.y = 3;
            }
        }

        rb.velocity = Velocity;

        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("throw", true);
        }
        else
        {
            anim.SetBool("throw", false);
        }

    }
}
