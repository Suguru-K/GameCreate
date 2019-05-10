using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRedBirthLeftScript : MonoBehaviour
{
    public GameObject Item_Red;  // 赤玉(Prefab)オブジェクト
    public int spawnFlagLeft = 0;  // 赤玉生成フラグ

    void Start()
    {
        //一定時間毎に実行
        InvokeRepeating("SpawnItem", 10f, 3f);
    }

    void Update()
    {

    }

    void SpawnItem()
    {
        //乱数生成(確率調整)
        int spawnFlagNum = Random.Range(1, 3);  // 確率1/3
        //Debug.Log("赤玉(左)乱数:" + spawnFlagNum);
        if (spawnFlagNum == 1)
        {
            // 生成
            spawnFlagLeft = 1;
            Instantiate(Item_Red, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            //Debug.Log("赤玉(左)生成フラグ:" + spawnFlagLeft);
        }
        else
        {
            // 未生成
            spawnFlagLeft = 0;
            //Debug.Log("赤玉(左)生成フラグ:" + spawnFlagLeft);
        }
    }
}
