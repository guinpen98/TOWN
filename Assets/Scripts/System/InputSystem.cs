using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 入力管理クラス
/// </summary>
public class InputSystem : BaseSystem, IPreUpdate
{

    public void PreUpdate()
    {
        SetKey();
        OnClickObject();
        DownSpaceKey();
    }

    void SetKey()
    {
        _gameState.onWKey = Input.GetKey(KeyCode.W);
        _gameState.onAKey = Input.GetKey(KeyCode.A);
        _gameState.onSKey = Input.GetKey(KeyCode.S);
        _gameState.onDKey = Input.GetKey(KeyCode.D);
    }

    void OnClickObject()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (!Physics.Raycast(ray, out hit)) return;

        _gameEvent.OnClickGameObject.Invoke(hit.transform.gameObject);
    }

    void DownSpaceKey()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        _gameEvent.DownSpaceKey.Invoke();
    }
}
