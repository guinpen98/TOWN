using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [SerializeField] GameState _gameState;
    GameEvent _gameEvent;

    List<BaseSystem> _baseSystemList;
    List<IPreUpdate> _preUpdateList;
    List<IOnUpdate> _onUpdateList;

    void Awake()
    {
        _gameEvent = new GameEvent();

        _baseSystemList = new List<BaseSystem>
        {

        };


    }

    void Update()
    {
        
    }
}
