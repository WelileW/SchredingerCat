using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public TubeCreatorControl _tubeCreator;
    private List<Crane> _cranes;
    public LeftCounterControl _airCounter;
    public RightCounterControl _poisonCounter;

    // Init
    void Awake()
    {
        StartLevel(GameStatus.Instance._level);
    }

    public void StartLevel(int level)
    {
        _cranes = _tubeCreator.Generate(Level.GetLevel(level), this);

        CheckMeasure();
    }

    public void CheckMeasure()
    {
        var airCheck = _cranes.Where(c => c.IsAir).Sum(c => c.Flow(LogicEnum.AirCounter));
        Debug.Log($"Воздуха в счетчике {airCheck}");
        _airCounter.SetScore(airCheck);

        var poisonCheck = _cranes.Where(c => !c.IsAir).Sum(c => c.Flow(LogicEnum.PoisonCounter));
        Debug.Log($"Яда в счетчике {poisonCheck}");
        _poisonCounter.SetScore(poisonCheck);
    }

    public bool CheckEnd()
    {
        var airCheck = _cranes.Where(c => c.IsAir).Sum(c => c.Flow(LogicEnum.Box));
        Debug.Log($"Воздуха в коробке {airCheck}");

        var poisonCheck = _cranes.Where(c => !c.IsAir).Sum(c => c.Flow(LogicEnum.Box));
        Debug.Log($"Яда в коробке {poisonCheck}");

        return airCheck != 0 && airCheck == poisonCheck;
    }
}
