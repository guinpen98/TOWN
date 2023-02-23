using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// シミュレーションに必要なコンポーネントクラス
/// </summary>
[System.Serializable]
public class AIComponent
{
    public NavMeshAgent navMeshAgent;
    public List<BaseState> stateList;

    [SerializeField] Transform sleepingPlaceTransform;
    public Vector3 sleepingPlace { get => sleepingPlaceTransform.position; }

    [SerializeField] Transform amusementPlaceTransform;
    public Vector3 amusementPlace { get => amusementPlaceTransform.position; }
}
