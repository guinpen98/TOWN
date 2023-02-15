using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameRule : BaseSystem
{
    public override void SetEvent()
    {
        _gameEvent.AriveDistination += SetAgentDistination;
        _gameEvent.OnClickGameObject += SetTaegetCamera;
        _gameEvent.DownSpaceKey += DeactiveTargetCamera;
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

    void DeactiveTargetCamera()
    {
        _gameEvent.DeactiveTargetCamera.Invoke();
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
