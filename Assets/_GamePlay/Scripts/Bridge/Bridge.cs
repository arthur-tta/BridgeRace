using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour

{
    public GameObject pieceOfBridge;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            Instantiate(pieceOfBridge, transform.parent);
            pieceOfBridge.transform.localPosition = transform.localPosition;
            transform.position = transform.position + new Vector3(0, 0.1f, 0.5f);
            Debug.Log(LevelManager.Ins.Player.brickOfPlayer.brickAmount);
        }
    }
}
