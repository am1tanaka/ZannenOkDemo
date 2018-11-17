using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class GameBehaviour : MonoBehaviour {
    [SerializeField]
    protected Text scoreText;

    /// <summary>
    /// ゲーム経過時間
    /// </summary>
    public static float gameTime
    {
        get;
        private set;
    }

    void Start()
    {
        gameTime = 0;
        AddScore(0);
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        // クリアチェック
        if (Ball.count <= 0)
        {
            ClearStage();
        }

        keyCkeck();
    }

    public abstract void AddScore(int sc);
    public abstract void ClearStage();
    protected virtual void keyCkeck() { }
}
