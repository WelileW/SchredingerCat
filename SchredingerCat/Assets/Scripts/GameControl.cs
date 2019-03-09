using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Singletone
    public static GameControl _instance;

    public TubeCreatorControl _tubeCreator;

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
        _tubeCreator.Generate(Level.GetLevelOne());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckMeasure()
    {
    }
}
