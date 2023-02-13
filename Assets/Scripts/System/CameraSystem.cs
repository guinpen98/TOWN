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

        if (!rootObject.TryGetComponent(out AgentEntity agentEntity))
            throw new System.NullReferenceException("AgentEntity script is not found");

        if (_gameState.cameraTargetAgent != null && _gameState.cameraTargetAgent.TryGetComponent(out AgentEntity preAgentEntity))
            preAgentEntity.agentCamera.SetActive(false);

        agentEntity.agentCamera.SetActive(true);
        _gameState.cameraTargetAgent = agentEntity.gameObject;

    }

    void DeactiveTargetCamera()
    {
        if (_gameState.cameraTargetAgent == null) return;
        if (!_gameState.cameraTargetAgent.TryGetComponent(out AgentEntity agentEntity)) return;
        agentEntity.agentCamera.SetActive(false);
        _gameState.cameraTargetAgent = null;
    }
}
