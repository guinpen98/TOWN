using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSystem : BaseSystem, IOnUpdate
{
    public void OnUpdate()
    {
        UpdateParamator();
    }

    void UpdateParamator()
    {
        foreach (var agentEntity in _gameState.agentEntities)
        {
            agentEntity.statusComponent.satiety -= Time.deltaTime;
        }
    }
}
