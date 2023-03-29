using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// システム層の呼び出し元のクラス
/// </summary>
public class GameMain : MonoBehaviour
{
    [SerializeField] GameState _gameState;
    GameEvent _gameEvent;

    List<IPreUpdate> _preUpdateList;
    List<IOnUpdate> _onUpdateList;
    List<ISystem> _systemList;

    void Awake()
    {
        _gameEvent = new GameEvent();
        _preUpdateList = new List<IPreUpdate>();
        _onUpdateList = new List<IOnUpdate>();
        _systemList = new List<ISystem>
        {
            new GameRule(),
            new SaveSystem(),
            new InputSystem(),
            new MoveSystem(),
            new TimeSystem(),
            new UISystem(),
            new DiurnalCycleSystem(),
            new CameraSystem(),
            new AgentSystem()
        };

        foreach(ISystem system in _systemList)
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
