using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Joystick joystick;
    public Rigidbody rigidbody;


    public BrickOfPlayer brickOfPlayer;
    public Animator playerAnimator;
    public bool isRun = false;
    
    



   

    private void FixedUpdate()
    {

        rigidbody.velocity = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            rigidbody.rotation = Quaternion.LookRotation(rigidbody.velocity);
            playerAnimator.SetBool("isRun", true);
        }
        else
        {
            playerAnimator.SetBool("isRun", false);
        }
    }

    
    public void AddBrick()
    {
        brickOfPlayer.AddBrick();
    }

    
   


}