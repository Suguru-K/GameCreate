using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript_start : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    // 起動時に実行
    void Start()
    {
        
    }

    // 毎フレーム毎に実行
    void Update()
    {
        
    }
}
