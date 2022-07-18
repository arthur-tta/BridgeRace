using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        if((transform.position - player.position).magnitude > 0.1f)
        {
            transform.position = player.position + offset;
        }
        
    }
}
