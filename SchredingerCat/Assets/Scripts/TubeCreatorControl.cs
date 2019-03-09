using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCreatorControl : MonoBehaviour
{
    public TubeControl _tubePattern;

    private float _titleHeight = 2;
    private float _titleWidth = 2;
    private float _z = 10;

    public void Generate()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                var adding = i > 2 ? 2 : 0;

                var control = Instantiate(_tubePattern, new Vector3(_titleHeight * (i - 3) + adding, _titleHeight * (j - 3), _z), Quaternion.identity);
                control.MultiRotate(i);
            }
        }
    }
}
