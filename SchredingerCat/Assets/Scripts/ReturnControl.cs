using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnControl : MonoBehaviour
{
    void OnMouseDown()
    {
        GameControl._instance.StartLevel();
    }
}
