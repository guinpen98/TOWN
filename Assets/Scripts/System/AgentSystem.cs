using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// エージェントの管理クラス
/// </summary>
public class AgentSystem : BaseSystem, IOnUpdate
{
    public void OnUpdate()
    {
        UpdateParamator();
        AgentSimulate();
    }

    /// <summary>
    /// パラメータの更新
    /// </summary>
    void UpdateParamator()
    {
        foreach (var agentEntity in _gameState.agentEntities)
        {
            agentEntity.statusComponent.satiety -= Time.deltaTime;
            agentEntity.statusComponent.sleepiness += Time.deltaTime;
        }
    }

    /// <summary>
    /// エージェントシミュレーション
    /// </summary>
    void AgentSimulate()
    {
        foreach(var agentEntity in _gameState.agentEntities)
        {
            foreach(var state in agentEntity.aiComponent.stateList)
            {
                if (!state.logic.Check(_gameState, agentEntity.statusComponent)) continue;
                state.action.Action(_gameState, _gameEvent, agentEntity);
                agentEntity.statusComponent.state = state.state;
                break;
            }
        }
    }
}
