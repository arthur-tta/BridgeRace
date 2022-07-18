using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public enum Flag { red, yellow, blue, violet, gray}
    private Flag flag;
    public int brickFlag;


    public Material[] materials;
    /*
        red = 1
        yellow = 2
        blue = 3
        violet = 4
        gray = 0
     
     */

    private void Start()
    {
 
    }


    
    
    public void SetFlag(int value)
    {
        brickFlag = value;
        //Debug.Log(brickFlag);
        Renderer ren = GetComponent<MeshRenderer>();
        ren.enabled = true;
        switch (value){
            case 1:
                flag = Flag.red;
                ren.sharedMaterial = materials[1];
                break;
            case 2:
                flag = Flag.yellow;
                ren.sharedMaterial = materials[2];
                break;
            case 3:
                flag = Flag.blue;
                ren.sharedMaterial = materials[3];
                break;
            case 4:
                flag = Flag.violet;
                ren.sharedMaterial = materials[4];
                break;
            case 0:
                flag = Flag.gray;
                ren.sharedMaterial = materials[0];
                break;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //.Log(brickFlag);

        if (other.CompareTag("Player") && LevelManager.Ins.CheckFlag(brickFlag))
        {
            //Debug.Log(brickFlag);
            LevelManager.Ins.Player.AddBrick();
            Destroy(gameObject);
            //TODO: pooling
        }
    }

   
}
