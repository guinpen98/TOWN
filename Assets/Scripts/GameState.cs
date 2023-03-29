using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// ゲームの状態を保持するクラスs
/// </summary>
[System.Serializable]
public class GameState
{
    // 定数
    public const float timeOfDay = 360;
    public const float timeOfHour = timeOfDay / 24;
    public const float timeOfMinute = timeOfHour/ 60;

    // SaveData
    public string filePath;
    public SaveData saveData;

    // Entity
    public PlayerEntity playerEntity;
    public AgentEntity[] agentEntities;

    // UI
    public TextMeshProUGUI timeText;
    public GameObject agentPanel;
    public TextMeshProUGUI hapinessText;
    public TextMeshProUGUI satietyText;
    public TextMeshProUGUI sleepinessText;
    public TextMeshProUGUI stateText;
    public Button saveButton;

    // GameObject
    public GameObject directionalLight;
    public AgentEntity cameraTargetEntity;

    // Facility
    public Transform housePosition;

    // ゲームの状態
    public float time;

    public bool onWKey;
    public bool onAKey;
    public bool onSKey;
    public bool onDKey;
}
