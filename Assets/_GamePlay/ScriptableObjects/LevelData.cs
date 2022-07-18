using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]

public class LevelData : ScriptableObject
{
    public int stageAmount;

    public int brickAmount;
    public int[] dataFlagOfBrick;
    public Vector3[] dataLocationOFBrick;

    

    public void InitData()
    {
        dataLocationOFBrick = new Vector3[brickAmount];
        dataFlagOfBrick = new int[brickAmount];


        for(int i = 0; i < brickAmount; i++)
        {
            dataFlagOfBrick[i] = Random.Range(1, 5);
        }
        int idex = 0;
        for (int j = -4; j < 4; j++)
        {
            for (int k = 0; k < brickAmount / 8; k++)
            {
                dataLocationOFBrick[idex] = new Vector3(j * 2 + 1, 1, k * 2 - 6);
                idex++;
            }
        }
    }


}
