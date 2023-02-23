using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// エージェントの状態を保持するクラス
/// </summary>
[System.Serializable]
public class StatusComponent
{
    public float satiety;
    public float happiness;
    public float sleepiness;
    public State state;
}
