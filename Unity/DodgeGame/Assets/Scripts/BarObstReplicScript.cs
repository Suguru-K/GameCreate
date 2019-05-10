using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarObstReplicScript : MonoBehaviour
{
    //　Barオブジェクトと結びつけ
    public GameObject BarObst;

    // 初期処理
    void Start()
    {
        //一定時間毎に実行する処理(実行するメソッド, 開始時間, 何秒ごと)
        InvokeRepeating("SpawnBar", 0f, 1.4f);
    }

    // フレーム毎処理
    void Update()
    {

    }

    void SpawnBar()
    {
        //壁(左)の座標を取得
        float cubeLeftThis = GameObject.Find("Cube_left").transform.position.z;
        //壁(右)の座標を取得
        //float cubeRightThis = GameObject.Find("Cube_right").transform.position.z;

        //インスタンス生成(インスタンス名, 生成位置, 回転)
        Instantiate(BarObst, new Vector3(transform.position.x, transform.position.y, Random.Range(cubeLeftThis + 3.0f, 2.0f)), transform.rotation);
    }
}
