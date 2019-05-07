using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour
{
    public void ReplayGame2()
    {
        SceneManager.LoadScene("MainScene");
    }

    // 初期処理
    void Start()
    {
        
    }

    // フレーム毎処理
    void Update()
    {
        
    }
}
