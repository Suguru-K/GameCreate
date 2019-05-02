using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        //インスタンスを使用する(ballインスタンス, ボールの位置, 回転を指定)

        InvokeRepeating("SpawnBall", 0f, 1f);
        //一定時間毎に実行する処理(実行するメソッド, 開始時間, 何秒ごと)
    }

    void SpawnBall()
    //ボール生成処理
    {
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
        //インスタンスオブジェクト生成(インスタンス, ボールの位置をランダムに(-5~5の位置に, yとzはballと同じ位置), 回転は変更無し)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
