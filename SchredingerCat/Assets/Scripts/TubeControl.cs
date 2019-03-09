using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Base class
public class TubeControl : MonoBehaviour
{
    private TubeControl _top = null;
    private TubeControl _bottom = null;
    private TubeControl _left = null;
    private TubeControl _right = null;

    public bool IsAir;

    public int Id;

    protected List<SideEnum> _connected;

    void OnMouseDown()
    {
        Rotate();

        GameControl._instance.CheckMeasure();
    }

    public void MultiRotate(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Rotate();
        }
    }

    public bool Flow(SideEnum flow, List<int> path)
    {
        if (path.Contains(Id))
            return false;

        var source = OppositeSide(flow);
        if (!_connected.Contains(source))
            return false;

        var newPath = new List<int>();
        newPath.AddRange(path);
        newPath.Add(Id);

        var newFlow = _connected.Where(s => s != source).ToList();

        if (newFlow.Contains(SideEnum.Top) && _top != null && _top.Flow(SideEnum.Top, newPath))
            return true;

        if (newFlow.Contains(SideEnum.Bottom) && _bottom != null && _bottom.Flow(SideEnum.Bottom, newPath))
            return true;

        if (newFlow.Contains(SideEnum.Right) && _right != null && _right.Flow(SideEnum.Right, newPath))
            return true;

        if (newFlow.Contains(SideEnum.Left) && _left != null && _left.Flow(SideEnum.Left, newPath))
            return true;

        return false;
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.forward * -90);

        var newConnected = new List<SideEnum>();
        foreach (var side in _connected)
            newConnected.Add(RotateSide(side));

        _connected = newConnected;
    }

    private SideEnum RotateSide(SideEnum side)
    {
        switch (side)
        {
            case SideEnum.Top:
                return SideEnum.Right;
            case SideEnum.Right:
                return SideEnum.Bottom;
            case SideEnum.Bottom:
                return SideEnum.Left;
            case SideEnum.Left:
                return SideEnum.Top;
            default:
                throw new System.Exception("Невозможно поменять сторону: Неизвестная сторона");
        }
    }

    private SideEnum OppositeSide(SideEnum side)
    {
        switch (side)
        {
            case SideEnum.Top:
                return SideEnum.Bottom;
            case SideEnum.Right:
                return SideEnum.Left;
            case SideEnum.Bottom:
                return SideEnum.Top;
            case SideEnum.Left:
                return SideEnum.Right;
            default:
                throw new System.Exception("Невозможно найти противоположную сторону: Неизвестная сторона");
        }
    }
}
