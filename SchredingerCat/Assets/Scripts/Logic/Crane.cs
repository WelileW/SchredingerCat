using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Crane
{
    private TubeControl _tube;
    private SideEnum _side;
    private int _force;

    public bool IsAir;

    public Crane(TubeControl tube, SideEnum side, int force, bool isAir)
    {
        _tube = tube;
        _side = side;
        _force = force;

        IsAir = isAir;
    }

    public int Flow(LogicEnum type)
    {
        if (_tube.Flow(_side, new List<int>(), type))
            return _force;

        return 0;
    }
}
