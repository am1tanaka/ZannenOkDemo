public class GameParams {

    const int SCORE_MAX = 9999999;

    public static int Score
    {
        get;
        private set;
    }
    public static int Stage
    {
        get;
        private set;
    }

    public static string ScoreString
    {
        get
        {
            return Score.ToString("D" + SCORE_MAX.ToString().Length);
        }
    }

    /// <summary>
    /// ゲーム開始時に呼び出して、パラメーターを初期化します。
    /// </summary>
    public static void GameStart()
    {
        Score = 0;
        Stage = 0;
    }

    /// <summary>
    /// スコアを加算
    /// </summary>
    /// <param name="sc">加算</param>
    public static void AddScore(int sc)
    {
        Score += sc;
        if (Score > SCORE_MAX)
        {
            Score = SCORE_MAX;
        }
    }

    /// <summary>
    // ステージのクリア
    /// </summary>
    public static void ClearStage()
    {
        Stage++;
    }
}
