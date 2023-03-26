using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 睡眠判定ロジック
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Logic/Create IsRecreation")]
public class IsRecreation : BaseLogic
{
    public override bool Check(GameState gameState, StatusComponent statusComponent)
    {
        return true;
    }
}