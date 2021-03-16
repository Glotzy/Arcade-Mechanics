using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); 
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }
    }
}
