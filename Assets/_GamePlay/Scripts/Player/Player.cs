using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Joystick joystick;
    public Rigidbody rigidbody;
    public Brick prefabBrick;


    //public int countStack = 5;


    public int playerFlag = 3;

   
    private void Update()
    {
        rigidbody.velocity = new Vector3(joystick.Horizontal * speed,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * speed);
    }


    public void AddBrick()
    {

    }
    

   

}