using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonScript : MonoBehaviour
{
    public void ToTitle()
    {
        // タイトルシーンに遷移
        SceneManager.LoadScene("TitleScene");
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
