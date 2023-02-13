using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class GameState
{
    // 定数
    public const float timeOfDay = 360;
    public const float timeOfHour = timeOfDay / 24;
    public const float timeOfMinute = timeOfHour/ 60;

    // Entity
    public PlayerEntity playerEntity;
    public AgentEntity agentEntity;

    // UI
    public TextMeshProUGUI timeText;

    // GameObject
    public GameObject directionalLight;
    public GameObject cameraTargetAgent;

    // Facility
    public Transform housePosition;

    // ゲームの状態
    public float time;

    public bool onWKey;
    public bool onAKey;
    public bool onSKey;
    public bool onDKey;
}
