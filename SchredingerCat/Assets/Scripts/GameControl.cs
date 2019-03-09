using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Singletone
    public static GameControl _instance;

    public TubeCreatorControl _tubeCreator;

    private List<Crane> _cranes;

    // Init
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        _cranes = _tubeCreator.Generate(Level.GetLevelOne());

        CheckMeasure();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckMeasure()
    {
        var airCheck = _cranes.Where(c => c.IsAir).Sum(c => c.Flow(LogicEnum.AirCounter));
        Debug.Log($"Воздуха в счетчике {airCheck}");

        var poisonCheck = _cranes.Where(c => !c.IsAir).Sum(c => c.Flow(LogicEnum.PoisonCounter));
        Debug.Log($"Яда в счетчике {poisonCheck}");
    }
}
