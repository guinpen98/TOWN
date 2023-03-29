using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 時間管理クラス
/// </summary>
public class TimeSystem : BaseSystem, IPreUpdate
{
    public override void Init(GameState gameState, GameEvent gameEvent)
    {
        base.Init(gameState, gameEvent);

        _gameState.time = _gameState.saveData.time;
    }

    public void PreUpdate()
    {
        _gameState.time += Time.deltaTime;
        if (_gameState.time > GameState.timeOfDay) _gameState.time = 0;
    }
}
