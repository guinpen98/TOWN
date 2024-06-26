using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// システムの抽象クラス
/// </summary>
public abstract class BaseSystem : ISystem
{
    protected GameState _gameState;
    protected GameEvent _gameEvent;

    public virtual void Init(GameState gameState, GameEvent gameEvent)
    {
        _gameState = gameState;
        _gameEvent = gameEvent;
    }

    public virtual void SetEvent() { }
}
