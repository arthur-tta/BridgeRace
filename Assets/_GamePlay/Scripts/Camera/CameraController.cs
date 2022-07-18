using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private Vector3 temp;

    void Update()
    {
        temp = player.transform.position;
        temp.y = 0f;
        transform.position = temp + offset;
    }
}
