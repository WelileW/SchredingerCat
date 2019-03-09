using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface BaseInterface
{
    bool Flow(SideEnum flow, List<int> path);
}
