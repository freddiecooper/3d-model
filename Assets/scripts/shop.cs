using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public Rigidbody gun;
    public Rigidbody shopfront;

    void Update()
    {
        if(Input.GetKey("e"))
        {
            Instantiate(gun, shopfront.position, shopfront.rotation);
        }
    }
}
