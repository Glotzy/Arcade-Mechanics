using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
      if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-4, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(4, 0, 0) * Time.deltaTime;
        }
    }
}
