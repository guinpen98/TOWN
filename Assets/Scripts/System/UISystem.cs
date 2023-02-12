using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : BaseSystem, IOnUpdate
{
    public void OnUpdate()
    {
        SetTimeText();
    }

    void SetTimeText()
    {
        int hour = Mathf.FloorToInt(_gameState.time / GameState.timeOfHour);
        int minute = Mathf.FloorToInt((_gameState.time % GameState.timeOfHour) / GameState.timeOfMinute);
        _gameState.timeText.text = "Time " + (hour < 10 ? "0" : "") + hour.ToString() + ":" + (minute < 10 ? "0" : "") + minute.ToString();
    }
}
