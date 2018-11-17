using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    const float POINT_MAX = 100;
    const float TIME_POINT_RATE = 10;

    GameBehaviour gameBehaviour;

    public static int count
    {
        get;
        private set;
    }

    private void Awake()
    {
        count = GameObject.FindGameObjectsWithTag("Ball").Length;
        gameBehaviour = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameBehaviour>();
    }

    private void OnMouseOver()
    {
        gameBehaviour.AddScore(calcPoint());
        count--;
        Destroy(gameObject);
    }

    int calcPoint()
    {
        int bpoint = (int)(POINT_MAX - GameBehaviour.gameTime * TIME_POINT_RATE);
        if (bpoint < 0)
        {
            return 0;
        }
        return bpoint;
    }
}
