using System.Collections;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform Player;

    void FixedUpdate()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
    }
  
}
