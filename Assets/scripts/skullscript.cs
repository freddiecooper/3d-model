using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skullscript : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Velocity = rb.velocity;
        
        if(Input.GetKey("a"))
        {
            Velocity.x=13;
        }
        else if(Input.GetKey("d"))
        {
            Velocity.x=-13;
        }
        else
        {
            Velocity.x=0;
        }

        if(Input.GetKey("w"))
        {
            Velocity.z=-13;
        }
        else if(Input.GetKey("s"))
        {
            Velocity.z=13;
        }
        else
        {
            Velocity.z=0;
        }

        if(Velocity.y == 0)
        {
            if(Input.GetKey("space"))
            {
                Velocity.y = 13;
            }
        }


        
        rb.velocity = Velocity;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("big ball"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
}
