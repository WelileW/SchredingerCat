using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCreatorControl : MonoBehaviour
{
    public StraightTubeControl _straightTubeControl;
    public AngleTubeControl _angleTubeControl;
    public ThreeTubeControl _threeTubePattern;
    public FourTubeControl _fourTubeControl;

    private float _titleHeight = 2.5F;
    private float _titleWidth = 2.5F;
    private float _z = 10;
    private float _space = 4.5F;

    private int _height;
    private int _width;

    private float _hCenter;
    private int _wCenter;

    private Level _level;

    private TubeControl[,] _map;

    public void Generate(Level level)
    {
        _height = level.Height;
        _width = level.Width;

        _level = level;

        _wCenter = _width / 2;
        _hCenter = _height / 2;

        _map = new TubeControl[_width, _height];

        // Создем трубы
        CreateTubes();

        // Прокидываем ссылки
        ConnectTubes();

        // Добавляем ссылки на краники

        // Добавляем ссылки на счетчики

        // Добавляем ссылки на ящик
    }

    private void CreateTubes()
    {
        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                var isAir = i < _wCenter;
                var adding = isAir ? -_space : _space;

                var control = Instantiate(
                    GetTubePattern(_level.Tubes[i,j]), 
                    new Vector3(_titleWidth * (i - _wCenter + 0.5F) + adding, _titleHeight * (j - _hCenter), _z), 
                    Quaternion.identity);

                control.MultiRotate(_level.Rotations[i, j]);
                control.IsAir = isAir;
                control.Id = i * 10 + j;

                _map[i, j] = control;
            }
        }
    }

    private TubeControl GetTubePattern(TubeType type)
    {
        switch (type)
        {
            case TubeType.Straight:
                return _straightTubeControl;
            case TubeType.Angle:
                return _angleTubeControl;
            case TubeType.Three:
                return _threeTubePattern;
            case TubeType.Four:
                return _fourTubeControl;
            default:
                throw new System.Exception("Создение трубы: неизвестный тип");
        }
    }

    private void ConnectTubes()
    {
        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                var tube = _map[i, j];

                tube.SetTop(FindTube(i, j + 1));
                tube.SetBottom(FindTube(i, j - 1));
                tube.SetLeft(FindTube(i - 1, j));
                tube.SetRight(FindTube(i + 1, j));
            }
        }

        for (int j = 0; j < _height; j++)
        {
            _map[_wCenter - 1, j].SetRight(null);
        }

        for (int j = 0; j < _height; j++)
        {
            _map[_wCenter, j].SetLeft(null);
        }
    }

    private TubeControl FindTube(int wigth, int height)
    {
        if (height < 0 || height >= _height)
            return null;

        if (wigth < 0 || wigth >= _width)
            return null;

        return _map[wigth, height];
    }

    private void ConnectCounter()
    {
        //_map[_wCenter - 1, _height - 1] = ;
        //_map[_wCenter, _height - 1] = ;
    }
}
