using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [SerializeField] GameState _gameState;
    GameEvent _gameEvent;

    List<IPreUpdate> _preUpdateList;
    List<IOnUpdate> _onUpdateList;
    List<ISystem> _baseSystemList;

    void Awake()
    {
        _gameEvent = new GameEvent();
        _preUpdateList = new List<IPreUpdate>();
        _onUpdateList = new List<IOnUpdate>();
        _baseSystemList = new List<ISystem>
        {
            new InputSystem(),
            new MoveSystem()
        };

        foreach(ISystem system in _baseSystemList)
        {
            system.Init(_gameState, _gameEvent);
            system.SetEvent();
            if (system is IPreUpdate) _preUpdateList.Add(system as IPreUpdate);
            if (system is IOnUpdate) _onUpdateList.Add(system as IOnUpdate);
        }


    }

    void Update()
    {
        foreach (var system in _preUpdateList) system.PreUpdate();
        foreach (var system in _onUpdateList) system.OnUpdate();
    }
}
