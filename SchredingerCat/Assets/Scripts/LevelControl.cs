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

    public ReturnControl RepeatControl;
    public NextControl NextControl;

    public Transform Box;
    public Transform Back;
    public Transform Cat;

    public Sprite PoisonedCat;
    public Sprite DiedCat;
    public Sprite SadCat;

    private bool _isEnd;
    private bool _isWin;
    private bool _isDied;

    private int _endCounter;

    // Init
    void Awake()
    {
        StartLevel(GameStatus.Instance._level);
    }

    private void Update()
    {
        if (_isEnd && _endCounter < 25)
        {
            Box.localScale += new Vector3(0.1F, 0.1F, 0);
            Back.localScale += new Vector3(0.1F, 0.1F, 0);
            Box.Translate(0.05F, 0, 0);
            Back.Translate(0.05F, 0, 0);
            _endCounter++;
        }
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

    public void CheckEnd()
    {
        _endCounter = 0;
        var airCheck = _cranes.Where(c => c.IsAir).Sum(c => c.Flow(LogicEnum.Box));
        Debug.Log($"Яда в коробке {airCheck}");

        var poisonCheck = _cranes.Where(c => !c.IsAir).Sum(c => c.Flow(LogicEnum.Box));
        Debug.Log($"Воздуха в коробке {poisonCheck}");

        _isWin = airCheck != 0 && airCheck == poisonCheck;
        _isDied = airCheck > poisonCheck;

        End();
    }

    private void End()
    {
        _isEnd = true;

        var spriteBox = Box.GetComponent<SpriteRenderer>();
        if (spriteBox)
            spriteBox.sortingOrder = 10;

        var spriteBack = Back.GetComponent<SpriteRenderer>();
        if (spriteBack)
            spriteBack.sortingOrder = 4;

        Sprite catState;
        if (_isWin)
        {
            catState = PoisonedCat;
        }
        else
        {
            catState = _isDied ? DiedCat : SadCat;
        }

        Cat.GetComponent<SpriteRenderer>().sprite = catState;

        Instantiate(RepeatControl, new Vector3(-9.4F, -3.5F, 0), Quaternion.identity);

        if (_isWin)
            Instantiate(NextControl, new Vector3(9.4F, -3.5F, 0), Quaternion.identity);
    }
}
