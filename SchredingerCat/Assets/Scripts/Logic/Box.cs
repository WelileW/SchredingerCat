using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box : BaseInterface
{
    public LogicEnum Type;

    public Box(LogicEnum type)
    {
        Type = type;
    }

    public bool Flow(SideEnum flow, List<int> path, LogicEnum type)
    {
        return Type == type;
    }
}
