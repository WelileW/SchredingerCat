using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTubeControl : TubeControl
{
    void Awake()
    {
        _connected = new List<SideEnum>();

        _connected.Add(SideEnum.Top);
        _connected.Add(SideEnum.Left);
    }
}
