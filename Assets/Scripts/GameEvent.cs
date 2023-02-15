using System;
using UnityEngine;
using UnityEngine.AI;

public class GameEvent
{
    public Action<NavMeshAgent, Vector3> AriveDistination;
    public Action<NavMeshAgent, Vector3> SetAgentDistination;
    public Action<GameObject> OnClickGameObject;
    public Action DownSpaceKey;
    public Action DeactiveTargetCamera;
    public Action<GameObject> SetTaegetCamera;
    public Action TargetedCamera;
    public Action ActiveAgentCanvas;
    public Action DeactiveAgentCanvas;
}
