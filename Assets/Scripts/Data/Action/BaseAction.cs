using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シミュレーションの行動ロジックの抽象クラス
/// </summary>
public abstract class BaseAction : ScriptableObject
{
    public abstract void Action(GameState gameState, GameEvent gameEvent, AgentEntity agentEntity);
}
