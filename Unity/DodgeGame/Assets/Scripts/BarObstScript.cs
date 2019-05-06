using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarObstScript : MonoBehaviour
{
    // Barの長さ
    //public float bar_length;
    // Barの速度
    public float bar_speed;

    public GameObject MainPersonObject;
    public MainPersonScript mainPersonScript;

    // 実行時初期処理
    void Start()
    {
        // Barの大きさは範囲内でランダム
        transform.localScale = new Vector3(1f, 1f, Random.Range(3f, 6f));

        MainPersonObject = GameObject.Find("MainPerson");
        mainPersonScript = MainPersonObject.GetComponent<MainPersonScript>();
    }

    // 毎フレーム実行処理
    void Update()
    {
        // x+方向に動く
        transform.position += new Vector3(bar_speed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //MainPersonに衝突した場合
        if (collision.gameObject.CompareTag("MainPerson"))
        {
            //ゲームオーバー
            SceneManager.LoadScene("GameOverScene");
            //Debug.Log("Bar:"+bar_speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //CubeBackに重なった場合
        if (other.gameObject.CompareTag("Cube_Back"))
        {
            //Barを消す
            Destroy(gameObject);
        }
    }
}