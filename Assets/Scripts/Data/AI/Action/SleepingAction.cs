using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 睡眠時の行動ロジック
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Action/SleepingAction")]
public class SleepingAction : BaseAction
{
    public float recoveryAmount;
    public override void Action(GameState gameState, GameEvent gameEvent, AgentEntity agentEntity)
    {
        agentEntity.aiComponent.navMeshAgent.SetDestination(agentEntity.aiComponent.sleepingPlace);
        Vector3 distance = agentEntity.transform .position- agentEntity.aiComponent.sleepingPlace;
        if(distance.sqrMagnitude < 1)
        {
            agentEntity.statusComponent.sleepiness -= Time.deltaTime * recoveryAmount;
        }
    }
}