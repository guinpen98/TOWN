using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : BaseSystem, IPreUpdate
{
    public void PreUpdate()
    {
        _gameState.onWKey = Input.GetKey(KeyCode.W);
        _gameState.onAKey = Input.GetKey(KeyCode.A);
        _gameState.onSKey = Input.GetKey(KeyCode.S);
        _gameState.onDKey = Input.GetKey(KeyCode.D);
    }
}
