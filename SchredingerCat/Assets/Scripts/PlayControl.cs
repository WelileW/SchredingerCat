using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    public LevelControl Level;

    void OnMouseDown()
    {
        Level.CheckEnd();
    }
}
