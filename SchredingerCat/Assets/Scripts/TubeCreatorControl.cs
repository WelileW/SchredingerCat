using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCreatorControl : MonoBehaviour
{
    public TubeControl _tubePattern;

    private float _titleHeight = 3;
    private float _titleWidth = 3;
    private float _z = 10;

    public void Generate()
    {
        for (int i = 0; i < 5; i++)
        {
            var control = Instantiate(_tubePattern, new Vector3(_titleWidth * i, _titleHeight * i, _z), Quaternion.identity);
            control.MultiRotate(i);
        }
    }
}
