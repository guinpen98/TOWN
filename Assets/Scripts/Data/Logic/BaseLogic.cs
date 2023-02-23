using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シミュレーションの条件判定ロジックの抽象クラス
/// </summary>
public abstract class BaseLogic : ScriptableObject
{
    public abstract bool Check(GameState gameState, StatusComponent statusComponent);
}