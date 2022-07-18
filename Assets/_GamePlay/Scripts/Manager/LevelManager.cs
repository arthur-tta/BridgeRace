using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    // Player
    public Player player;
    public Player Player => player;
   

    // Data
    private int brickAmount;
    public LevelData levelData;
    public Brick brick;




    private void Start()
    {

        levelData.InitData();
        InitData();
    }

    public void InitData()
    {
        //Debug.Log(brickAmount);
        brickAmount = levelData.brickAmount;
        for (int i = 0; i < brickAmount; i++)
        {
            Instantiate(brick, levelData.dataLocationOFBrick[i], Quaternion.identity);
            brick.SetFlag(levelData.dataFlagOfBrick[i]);
        }
    }

    public bool CheckFlag(int value)
    {
        if(value == 0)
        {
            return true;
        }
        else {
            return value == Player.brickOfPlayer.playerFlag;
        }
    }
    


}
