using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NGGameBehaviour : GameBehaviour {

    [SerializeField]
    int SCORE_MAX = 9999999;

    int Score = 0;
    int Stage = 0;

    void stageClear()
    {
        // クリア
        Stage++;
        if (Stage <2)
        {
            // 次のシーンへ
            SceneManager.LoadScene("NGStage"+(Stage+1));
        }
        else
        {
            // タイトルへ
            SceneManager.LoadScene("NGTitle");
        }
    }

    /// <summary>
    /// スコアを加算
    /// </summary>
    /// <param name="sc">加算</param>
    public override void AddScore(int sc)
    {
        Score += sc;
        if (Score > SCORE_MAX)
        {
            Score = SCORE_MAX;
        }
        scoreText.text = "SCORE " + Score.ToString("D" + SCORE_MAX.ToString().Length);
    }
    
    // ステージのクリア処理
    public override void ClearStage()
    {
        Stage++;

        if (Stage < 2)
        {
            // ステージ2まである
            SceneManager.LoadScene("NGStage" + (Stage + 1));
        }
        else
        {
            // ステージ3になっていたらタイトルへ
            SceneManager.LoadScene("NGTitle");
        }
    }

    protected override void keyCkeck()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("NGTitle");
        }
    }
}
