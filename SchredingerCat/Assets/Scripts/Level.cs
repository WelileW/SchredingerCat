using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Level
{
    public int Height;
    public int Width; // Четное

    // Ширина, Высота
    public TubeType[,] Tubes;
    public int[,] Rotations;

    // Местоположение, Сила
    public Dictionary<int, int> СraneAir;
    public Dictionary<int, int> CranePoison;

    public static Level GetLevelOne()
    {
        var level = new Level();

        level.Height = 5;
        level.Width = 6;

        level.Tubes = new TubeType[,] 
        {
                { TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four },
                { TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four },
                { TubeType.Four, TubeType.Straight, TubeType.Four, TubeType.Four, TubeType.Four },
                { TubeType.Three, TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four },
                { TubeType.Three, TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four },
                { TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four, TubeType.Four }
        };

        level.CranePoison = new Dictionary<int, int>();
        level.CranePoison.Add(1, 1);

        level.СraneAir = new Dictionary<int, int>();
        level.СraneAir.Add(1, 1);

        return level;
    }
}