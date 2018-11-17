using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NGTitleBehaviour : MonoBehaviour {	

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("NGStage1");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Title");
        }
	}
}
