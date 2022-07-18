using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Joystick joystick;
    public Rigidbody rigidbody;
    public BrickOfPlayer brickOfPlayer;

    public float velocityY;

   
    private void Update()
    {
        rigidbody.velocity = new Vector3(joystick.Horizontal * speed,
                                         velocityY,
                                         joystick.Vertical * speed);
        velocityY = -1;
    }


    public void AddBrick()
    {
        brickOfPlayer.AddBrick();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bridge" && brickOfPlayer.brickAmount > 0)
        {
            transform.position = transform.position + new Vector3(0, 0.1f, 0.3f);
            brickOfPlayer.brickAmount--;
        }
    }


}