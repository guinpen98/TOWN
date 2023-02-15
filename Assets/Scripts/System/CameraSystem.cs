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

        if (_gameState.cameraTargetEntity != null)
            _gameState.cameraTargetEntity.agentCamera.SetActive(false);

        agentEntity.agentCamera.SetActive(true);
        _gameState.cameraTargetEntity = agentEntity;
        _gameEvent.TargetedCamera.Invoke();
    }

    void DeactiveTargetCamera()
    {
        if (_gameState.cameraTargetEntity == null) return;
        _gameState.cameraTargetEntity.agentCamera.SetActive(false);
        _gameState.cameraTargetEntity = null;
    }
}
