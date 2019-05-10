using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarObstScript : MonoBehaviour
{
    public float bar_speed = 5f;  // Barの速度
    public GameObject MainPersonObject;  //MainPersonオブジェクト
    public MainPersonScript mainPersonScript;  //MainPersonスクリプト

    void Start()
    {
        // Barの大きさは範囲内でランダム
        transform.localScale = new Vector3(1f, 1f, Random.Range(4f, 5f));
        // MainPersonのスクリプト呼び出し
        MainPersonObject = GameObject.Find("MainPerson");
        mainPersonScript = MainPersonObject.GetComponent<MainPersonScript>();
    }

    void Update()
    {
        // x+方向のみに動く
        transform.position += new Vector3(bar_speed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //MainPersonに衝突した場合
        if (collision.gameObject.CompareTag("MainPerson"))
        {
            //ゲームオーバー
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //CubeBackに重なった場合
        if (other.gameObject.CompareTag("Cube_Back_Empty"))
        {
            //Barを消す
            Destroy(gameObject);
        }
    }
}