using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Counter : BaseInterface
{
    public LogicEnum Type;

    public Counter(LogicEnum type)
    {
        Type = type;
    }

    public bool Flow(SideEnum flow, List<int> path, LogicEnum type)
    {
        Debug.Log($"Путь до счетчика {type} : {String.Join(", ", path)}");
        return Type == type;
    }
}