using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState {  GameOver, GameStart, GameIdle};
    public static GameState CurrentState = GameState.GameIdle;

    public static GameManager thisManager;

    public static int Lives = 3;
    public static int Score = 0;

    

    void Start()
    {
        Lives = 3;
        Score = 0;
        Time.timeScale = 0;
        CurrentState = GameState.GameIdle;

        thisManager = this;
    }
    
    void Update()
    {
        if(CurrentState == GameState.GameIdle && Input.GetKeyDown(KeyCode.Return))
        {            
            CurrentState = GameState.GameStart;
            Time.timeScale = 1;
            HUD.HUDManager.DismissMessage();
        }

        else if(CurrentState == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameLevel");
        }

        if (Lives == 0)
        {
            CurrentState = GameState.GameOver;
            HUD.HUDManager.GameOver();
        }
    }

    public void UpdateLive()
    {
        Lives -= 1;      
    }
    public void UpdateScore()
    {
        Score++;
    }
}
