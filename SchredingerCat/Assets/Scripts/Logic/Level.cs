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

    public static Level GetLevel(int level)
    {
        switch (level)
        {
            case 1:
                return GetLevelOne();
            case 2:
                return GetLevelTwo();
            case 3:
                return GetLevelThree();
            default:
                return null;
        }
    }

    public static Level GetLevelOne()
    {
        var level = new Level();

        level.Height = 5;
        level.Width = 6;

        level.Tubes = new TubeType[,] 
        {
                { TubeType.Straight, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
                { TubeType.Three, TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Four },
                { TubeType.Straight, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Straight },
                { TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
                { TubeType.Three, TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Straight },
                { TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Straight, TubeType.Angle }
        };

        level.Rotations = new int[,]
        {
                { 1, 2, 0, 3, 3 },
                { 3, 0, 0, 2, 2 },
                { 0, 3, 2, 0, 0 },
                { 2, 1, 1, 3, 0 },
                { 1, 2, 0, 2, 0 },
                { 3, 0, 1, 0, 2 }
        };

        level.CranePoison = new Dictionary<int, int>();
        level.CranePoison.Add(1, 1);

        level.СraneAir = new Dictionary<int, int>();
        level.СraneAir.Add(1, 1);

        return level;
    }

    public static Level GetLevelTwo()
    {
        var level = new Level();

        level.Height = 5;
        level.Width = 6;

        level.Tubes = new TubeType[,]
        {
                { TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Straight, TubeType.Angle },
                { TubeType.Three, TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Straight },
                { TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
                { TubeType.Four, TubeType.Three, TubeType.Straight, TubeType.Three, TubeType.Straight },
                { TubeType.Three, TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Four },
                { TubeType.Straight, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
        };

        level.Rotations = new int[,]
        {
                { 1, 2, 0, 3, 3 },
                { 3, 0, 0, 2, 2 },
                { 0, 3, 2, 0, 0 },
                { 2, 1, 1, 3, 0 },
                { 1, 2, 0, 2, 0 },
                { 3, 0, 1, 0, 2 }
        };

        level.CranePoison = new Dictionary<int, int>();
        level.CranePoison.Add(1, 1);
        level.CranePoison.Add(2, 2);

        level.СraneAir = new Dictionary<int, int>();
        level.СraneAir.Add(1, 2);
        level.СraneAir.Add(2, 3);

        return level;
    }

    public static Level GetLevelThree()
    {
        var level = new Level();

        level.Height = 5;
        level.Width = 6;

        level.Tubes = new TubeType[,]
        {
                { TubeType.Straight, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
                { TubeType.Three, TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Four },
                { TubeType.Straight, TubeType.Straight, TubeType.Straight, TubeType.Three, TubeType.Straight },
                { TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Three, TubeType.Angle },
                { TubeType.Three, TubeType.Three, TubeType.Straight, TubeType.Angle, TubeType.Straight },
                { TubeType.Angle, TubeType.Straight, TubeType.Angle, TubeType.Straight, TubeType.Angle }
        };

        level.Rotations = new int[,]
        {
                { 1, 2, 0, 3, 3 },
                { 3, 0, 0, 2, 2 },
                { 0, 3, 2, 0, 0 },
                { 2, 1, 1, 3, 0 },
                { 1, 2, 0, 2, 0 },
                { 3, 0, 1, 0, 2 }
        };

        level.CranePoison = new Dictionary<int, int>();
        level.CranePoison.Add(1, 2);
        level.CranePoison.Add(2, 3);
        level.CranePoison.Add(3, 1);
        level.CranePoison.Add(4, 2);

        level.СraneAir = new Dictionary<int, int>();
        level.СraneAir.Add(1, 1);
        level.СraneAir.Add(2, 2);
        level.СraneAir.Add(3, 4);
        level.СraneAir.Add(4, 1);


        return level;
    }
}