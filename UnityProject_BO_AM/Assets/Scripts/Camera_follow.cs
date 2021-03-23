using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform target;

    public float smoohSpeed = 0.125f;

    void LateUpdate()
    {
        transform.position = target.position;
    }
}
