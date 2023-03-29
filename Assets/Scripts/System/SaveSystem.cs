using System.IO;
using UnityEngine;

public class SaveSystem : BaseSystem 
{
    public override void Init(GameState gameState, GameEvent gameEvent)
    {
        base.Init(gameState, gameEvent);

        _gameState.filePath = Application.persistentDataPath + "/" + ".savedata.json";
        Load();
    }

    public override void SetEvent()
    {
        _gameEvent.Save += Save;
    }

    public void Save()
    {
        _gameState.saveData.time = (int)_gameState.time;
        string json = JsonUtility.ToJson(_gameState.saveData);
        StreamWriter streamWriter = new StreamWriter(_gameState.filePath);
        streamWriter.Write(json); streamWriter.Flush();
        streamWriter.Close();

    }

    public void Load()
    {
        if (File.Exists(_gameState.filePath))
        {
            StreamReader streamReader;
            streamReader = new StreamReader(_gameState.filePath);
            string data = streamReader.ReadToEnd();
            streamReader.Close();
            _gameState.saveData = JsonUtility.FromJson<SaveData>(data);
        }
        else
        {
            _gameState.saveData = new();
        }
    }

}