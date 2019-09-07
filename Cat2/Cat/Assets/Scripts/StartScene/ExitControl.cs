using UnityEngine;
using UnityEditor;
using System;

public class ExitControl : ButtonControl
{
    public StartController MainController;
    private void OnMouseDown()
    {
        Debug.Log("321");
        base.OnMouseDown();
        MainController.Exit();
    }
}