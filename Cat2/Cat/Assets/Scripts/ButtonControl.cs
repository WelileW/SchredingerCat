using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    void OnMouseDown()
    {
        var selecting = gameObject.transform.GetChild(0).gameObject;
        selecting.SetActive(true);
    }

    void OnMouseUp()
    {
        var selecting = gameObject.transform.GetChild(0).gameObject;
        selecting.SetActive(false);
    }
}
