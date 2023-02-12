using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : BaseSystem, IPreUpdate
{
    public void PreUpdate()
    {
        _gameState.time += Time.deltaTime;
        if (_gameState.time > GameState.timeOfDay) _gameState.time = 0;
    }
}
