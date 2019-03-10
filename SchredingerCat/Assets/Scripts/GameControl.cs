using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Title,
    Disclaimer,
    Level,
    Final
}

public class GameControl : Singleton<GameControl>
{
    // Singletone
    public static GameControl _instance;

    //// Init
    void Awake()
    {
        _instance = this;
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isMouse && e.type == EventType.MouseDown)
        {
            switch (GameStatus.Instance._state)
            {
                case GameState.Title:
                    SceneManager.LoadScene("disclaimer", LoadSceneMode.Single);
                    GameStatus.Instance._state = GameState.Disclaimer;
                    break;
                case GameState.Disclaimer:
                    SceneManager.LoadScene("level", LoadSceneMode.Single);
                    GameStatus.Instance._state = GameState.Level;
                    break;
                default:
                    break;
            }
        }
    }


}
