using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Level
{
    public int Height;
    public int Width;

    public TubeType[,] Tubes;
    public int[,] Rotations;

    // Местоположение, Сила
    public Dictionary<int, int> СraneAir;
    public Dictionary<int, int> CranePoison;
}