using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 娯楽時の行動ロジック
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Action/AmusementAction")]
public class AmusementAction : BaseAction
{
    public float recoveryAmount;
    public override void Action(GameState gameState, GameEvent gameEvent, AgentEntity agentEntity)
    {
        agentEntity.aiComponent.navMeshAgent.SetDestination(agentEntity.aiComponent.amusementPlace);
        Vector3 distance = agentEntity.transform .position- agentEntity.aiComponent.amusementPlace;
        if(distance.sqrMagnitude < 1)
        {
            agentEntity.statusComponent.happiness += Time.deltaTime * recoveryAmount;
        }
    }
}