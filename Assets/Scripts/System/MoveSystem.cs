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
        AgentsMovement();
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

    void AgentsMovement()
    {
        RotateAgents();

        foreach (var agentEntity in _gameState.agentEntity)
        {
            if (agentEntity.aiComponent.navMeshAgent.remainingDistance > agentEntity.aiComponent.navMeshAgent.stoppingDistance) continue;
            SetAgentDistination(agentEntity.aiComponent.navMeshAgent, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)));
        }
    }

    void RotateAgents()
    {
        foreach(var agentEntity in _gameState.agentEntity)
        {
            Vector3 nextPoint = agentEntity.aiComponent.navMeshAgent.steeringTarget;
            Vector3 targetDir = nextPoint - agentEntity.transform.position;
            if (targetDir == Vector3.zero) return;

            Quaternion targetRotation = Quaternion.LookRotation(targetDir);
            agentEntity.transform.rotation = Quaternion.RotateTowards(agentEntity.transform.rotation, targetRotation, 120f * Time.deltaTime);
        }
    }

    void SetAgentDistination(NavMeshAgent navMeshAgent, Vector3 distination)
        => navMeshAgent.SetDestination(distination);
}
