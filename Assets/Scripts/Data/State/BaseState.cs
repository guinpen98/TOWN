using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// シミュレーションのステート。条件判定ロジックと行動ロジックをもつ
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/State/Create BaseState")]
public class BaseState : ScriptableObject
{
    public State state;
    public BaseLogic logic;
    public BaseAction action;
}