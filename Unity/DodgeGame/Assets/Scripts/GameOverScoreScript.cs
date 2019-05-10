using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Score表示用

public class GameOverScoreScript : MonoBehaviour
{
    public Text scoreText; //Text用変数
    int score; //スコア計算用変数

    void Start()
    {
        score = MainPersonScript.GetItemRedGetNum();
        // スコア表示
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        
    }
}
