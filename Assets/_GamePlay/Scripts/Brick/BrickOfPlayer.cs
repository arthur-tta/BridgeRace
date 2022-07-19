using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickOfPlayer : MonoBehaviour

{
    
    public Brick prefabBrick;
    public int brickAmount = 0;
    public int playerFlag = 3;

    
    public void AddBrick()
    {
        brickAmount++;
        prefabBrick = Instantiate(prefabBrick, transform.parent);
        prefabBrick.transform.localPosition = transform.localPosition + new Vector3(0, 0.2f * brickAmount, -1);
        prefabBrick.SetFlag(playerFlag);
    }
    
}
