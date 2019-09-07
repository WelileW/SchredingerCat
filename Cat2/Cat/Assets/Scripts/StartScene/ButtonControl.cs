using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    protected void OnMouseDown()
    {
        Debug.Log("___");
        var selecting = gameObject.transform.GetChild(0).gameObject;
        selecting.SetActive(true);
    }

    protected void OnMouseUp()
    {
        var selecting = gameObject.transform.GetChild(0).gameObject;
        selecting.SetActive(false);
    }
}
