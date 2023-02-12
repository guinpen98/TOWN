using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiurnalCycleSystem : BaseSystem, IOnUpdate
{
    public void OnUpdate()
    {
        _gameState.directionalLight.transform.rotation = Quaternion.Euler(_gameState.time / 1.5f - 30, -90f, -90f);
    }
}
