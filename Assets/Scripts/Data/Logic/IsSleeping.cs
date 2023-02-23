using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 睡眠判定ロジック
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Logic/Create IsSleeping")]
public class IsSleeping : BaseLogic
{
    public float sleeping_threshold;
    public float not_sleeping_threshold;
    public override bool Check(GameState gameState, StatusComponent statusComponent)
    {
        if(statusComponent.state == State.Sleeping) return statusComponent.sleepiness > sleeping_threshold;
        return statusComponent.sleepiness > not_sleeping_threshold;
    }
}