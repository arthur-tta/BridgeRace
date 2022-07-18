using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MainMenu, GamePlay, Pause}


public class GameManager : Singleton<GameManager>
{

    private static GameState gameState;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Input.multiTouchEnabled = false;
    }


    public void ChangeState(GameState state)
    {
        gameState = state;
    }

    public bool IsGameState(GameState state)
    {
        return state == gameState;
    }
}
