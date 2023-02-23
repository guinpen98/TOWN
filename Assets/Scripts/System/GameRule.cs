using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// イベントの管理クラス
/// </summary>
public class GameRule : BaseSystem
{
    public override void SetEvent()
    {
        _gameEvent.AriveDistination += SetAgentDistination;
        _gameEvent.OnClickGameObject += SetTaegetCamera;
        _gameEvent.DownSpaceKey += SetCamera;
        _gameEvent.DownSpaceKey += DeactiveAgentCanvas;
        _gameEvent.TargetedCamera += ActiveAgentCanvas;
    }

    void SetAgentDistination(NavMeshAgent agent, Vector3 distination)
    {
        _gameEvent.SetAgentDistination.Invoke(agent, distination);
    }

    void SetTaegetCamera(GameObject gameObject)
    {
        _gameEvent.SetTaegetCamera.Invoke(gameObject);
    }

    void SetCamera()
    {
        _gameEvent.SetCamera.Invoke();
    }

    void ActiveAgentCanvas()
    {
        _gameEvent.ActiveAgentCanvas.Invoke();
    }

    void DeactiveAgentCanvas()
    {
        _gameEvent.DeactiveAgentCanvas.Invoke();
    }
}
