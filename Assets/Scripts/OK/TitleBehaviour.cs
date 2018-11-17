using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleBehaviour : MonoBehaviour {
    [SerializeField]
    Text scoreText;

    private void Start()
    {
        scoreText.text = "SCORE " + GameParams.ScoreString;
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // 以下がないと、初期化が実施されない
            //GameParams.GameStart();

            SceneManager.LoadScene("Stage1");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("NGTitle");
        }
	}
}
