using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ReplayGame()
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
