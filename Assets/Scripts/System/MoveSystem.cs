using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : BaseSystem, IOnUpdate
{
    public void OnUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        RotatePlayer();
        MovePlayer();
    }

    void RotatePlayer()
    {
        if (_gameState.onAKey) _gameState.playerEntity.transform.Rotate(0, -_gameState.playerEntity.moveComponent.rotateSpeed * Time.deltaTime, 0);
        if (_gameState.onDKey) _gameState.playerEntity.transform.Rotate(0, _gameState.playerEntity.moveComponent.rotateSpeed * Time.deltaTime, 0);
    }

    void MovePlayer()
    {
        if (!_gameState.onWKey && !_gameState.onSKey) return;
        int direction = _gameState.onWKey ? 1 : -1;
        _gameState.playerEntity.rb.velocity = _gameState.playerEntity.transform.forward * _gameState.playerEntity.moveComponent.walkSpeed * direction;
    }
}
