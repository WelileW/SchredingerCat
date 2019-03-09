using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Rotate();

        GameControl._instance.CheckMeasure();
    }

    public void MultiRotate(int count)
    {
        transform.Rotate(Vector3.forward * -90 * count);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.forward * -90);
    }
}
