using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRedBirthRightScript : MonoBehaviour
{
    public GameObject Item_Red;  // 赤玉(Prefab)オブジェクト
    public GameObject itemRedBirthLeft;  // 赤玉(左, Empty)オブジェクト
    ItemRedBirthLeftScript script;  // 赤玉(左, Empty)スクリプト
    public int spawnFlagRight = 0;  // 赤玉(右)生成フラグ
    int leftSpawnFlag;  // 赤玉(左)生成フラグ

    void Start()
    {
        //赤玉(左, Empty)オブジェクトを取得
        itemRedBirthLeft = GameObject.Find("ItemRedBirthLeft");
        //赤玉(左, Empty)スクリプトを呼び出し
        script = itemRedBirthLeft.GetComponent<ItemRedBirthLeftScript>();

        //一定時間毎に実行(左より微フレーム遅く)
        InvokeRepeating("SpawnItem", 10.001f, 3.001f);
    }

    void Update()
    {

    }

    void SpawnItem()
    {
        leftSpawnFlag = script.spawnFlagLeft;
        //乱数生成(確率調整)
        int spawnFlagNum = Random.Range(1, 2);

        if (spawnFlagNum == 1)
        {
            // 生成
            if (leftSpawnFlag == 1)
            {
                // 左が生成されていたら右は生成しない
                return;
            }
            spawnFlagRight = 1;
            Instantiate(Item_Red, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        }
        else
        {
            // 未生成
            spawnFlagRight = 0;
        }
    }
}
