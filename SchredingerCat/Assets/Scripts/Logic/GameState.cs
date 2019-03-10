using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameStatus : Singleton<GameStatus>
{
    public int _level = 1;
    public GameState _state = GameState.Title;
}
