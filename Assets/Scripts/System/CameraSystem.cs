using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : BaseSystem
{
    public override void SetEvent()
    {
        _gameEvent.SetTaegetCamera += SetTaegetCamera;
        _gameEvent.DeactiveTargetCamera += DeactiveTargetCamera;
    }

    void SetTaegetCamera(GameObject gameObject)
    {
        GameObject rootObject = gameObject.transform.root.gameObject;
        if (!rootObject.CompareTag("Agent")) return;

        if (rootObject.TryGetComponent(out AgentEntity agentEntity))
        {
            if (agentEntity.agentCamera.activeSelf) return;
            agentEntity.agentCamera.SetActive(true);
            _gameState.activeCamera = agentEntity.agentCamera;
        }
        else throw new System.NullReferenceException("AgentEntity script is not found");
    }

    void DeactiveTargetCamera()
    {
        if (_gameState.activeCamera == null) return;

        _gameState.activeCamera.SetActive(false);
        _gameState.activeCamera = null;
    }
}
