using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        _gameState.satietyText.text = "Satiety " + _gameState.cameraTargetEntity.statusComponent.satiety.ToString();
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
