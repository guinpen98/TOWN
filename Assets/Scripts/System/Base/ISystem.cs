/// <summary>
/// システムのインターフェイス
/// </summary>
interface ISystem
{
    /// <summary>初期化</summary>
    void Init(GameState gameState, GameEvent gameEvent);

    /// <summary>イベントに登録</summary>
    void SetEvent();
}
