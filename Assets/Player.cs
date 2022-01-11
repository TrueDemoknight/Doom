using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rigidbody.AddForce(Vector3.forward);
        }

        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z), Vector3.down, 1f))
        {
            Debug.Log("Grounded");
            rigidbody.AddForce(-Physics.gravity * rigidbody.mass);
        }
    }
}
