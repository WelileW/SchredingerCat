using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextControl : MonoBehaviour
{
    void OnMouseDown()
    {
        GameStatus.Instance._level = GameStatus.Instance._level + 1;
        GameControl._instance.StartLevel();
    }
}
