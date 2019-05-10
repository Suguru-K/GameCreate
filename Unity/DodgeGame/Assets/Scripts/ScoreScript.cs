using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Score表示用

public class ScoreScript : MonoBehaviour
{
    public Text scoreText; //Text用変数
    int score; //スコア計算用変数

    void Start()
    {
        //初期スコア表示
        scoreText.text = "Score: 0";
    }

    void Update()
    {
        score = MainPersonScript.GetItemRedGetNum();  // スコアは赤玉取得数*10
        // スコア表示
        scoreText.text = "Score: " + score.ToString();
    }

}
