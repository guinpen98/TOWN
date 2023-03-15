using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI管理クラス
/// </summary>
public class UISystem : BaseSystem, IOnUpdate
{
    public override void SetEvent()
    {
        _gameEvent.ActiveAgentCanvas += ActiveAgentCanvas;
        _gameEvent.DeactiveAgentCanvas += DeactiveAgentCanvas;
    }

    public void OnUpdate()
    {
        UpdateTimeText();
        UpdateAgentUI();
    }

    void UpdateTimeText()
    {
        int hour = Mathf.FloorToInt(_gameState.time / GameState.timeOfHour);
        int minute = Mathf.FloorToInt((_gameState.time % GameState.timeOfHour) / GameState.timeOfMinute);
        _gameState.timeText.text = "Time " + (hour < 10 ? "0" : "") + hour.ToString() + ":" + (minute < 10 ? "0" : "") + minute.ToString();
    }

    void UpdateAgentUI()
    {
        if (_gameState.cameraTargetEntity == null) return;

        _gameState.hapinessText.text = "Hapiness " + _gameState.cameraTargetEntity.statusComponent.happiness.ToString("f0");
        _gameState.satietyText.text = "Satiety " + _gameState.cameraTargetEntity.statusComponent.satiety.ToString("f0");
        _gameState.sleepinessText.text = "Sleepiness " + _gameState.cameraTargetEntity.statusComponent.sleepiness.ToString("f0");
        _gameState.stateText.text = "State " + _gameState.cameraTargetEntity.statusComponent.state;
    }

    void ActiveAgentCanvas()
    {
        _gameState.agentPanel.SetActive(true);
    }

    void DeactiveAgentCanvas()
    {
        _gameState.agentPanel.SetActive(false);
    }
}
