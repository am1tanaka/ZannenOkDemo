using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OKGameBehaviour : GameBehaviour
{
    void stageClear()
    {
        // クリア
        GameParams.ClearStage();
        if (GameParams.Stage < 2)
        {
            // 次のシーンへ
            SceneManager.LoadScene("OKStage" + (GameParams.Stage + 1));
        }
        else
        {
            // タイトルへ
            SceneManager.LoadScene("OKTitle");
        }
    }

    /// <summary>
    /// スコアを加算
    /// </summary>
    /// <param name="sc">加算</param>
    public override void AddScore(int sc)
    {
        GameParams.AddScore(sc);
        scoreText.text = "SCORE " + GameParams.ScoreString;
    }

    // ステージのクリア処理
    public override void ClearStage()
    {
        GameParams.ClearStage();
        if (GameParams.Stage < 2)
        {
            // ステージ2まである
            SceneManager.LoadScene("Stage" + (GameParams.Stage + 1));
        }
        else
        {
            // ステージ3になっていたらタイトルへ
            SceneManager.LoadScene("Title");
        }
    }
}
