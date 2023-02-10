using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveSystem : BaseSystem, IOnUpdate
{
    public override void SetEvent()
    {
        _gameEvent.SetAgentDistination += SetAgentDistination;
    }

    public void OnUpdate()
    {
        PlayerMovement();
        AgentMovement();
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
        if (!_gameState.onWKey && !_gameState.onSKey)
        {
            _gameState.playerEntity.rb.velocity = Vector3.zero;
            return;
        }
        int direction = _gameState.onWKey ? 1 : -1;
        _gameState.playerEntity.rb.velocity = _gameState.playerEntity.transform.forward * _gameState.playerEntity.moveComponent.walkSpeed * direction;
    }

    void AgentMovement()
    {
        if (_gameState.agentEntity.navMeshAgent.remainingDistance <= _gameState.agentEntity.navMeshAgent.stoppingDistance)
        {
            SetAgentDistination(_gameState.agentEntity.navMeshAgent, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)));
        }
    }

    void SetAgentDistination(NavMeshAgent navMeshAgent, Vector3 distination)
        => navMeshAgent.SetDestination(distination);
}
