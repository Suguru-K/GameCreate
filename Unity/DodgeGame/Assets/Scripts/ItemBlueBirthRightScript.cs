using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlueBirthRightScript : MonoBehaviour
{
    public GameObject Item_Blue;  //アイテム(Prefab)オブジェクト
    public GameObject itemBlueBirthLeft;  //アイテム発生源(左, Empty)オブジェクト
    ItemBlueBirthLeftScript script;  //アイテム発生源(左)スクリプト
    public int spawnFlagRight = 0;  //アイテム発生(右)フラグ
    int leftSpawnFlag;  //アイテム発生(左)フラグ

    void Start()
    {
        //アイテム発生源(左, Empty)オブジェクトをfind
        itemBlueBirthLeft = GameObject.Find("ItemBlueBirthLeft");

        //アイテム発生源(左)スクリプトを呼び出し
        script = itemBlueBirthLeft.GetComponent<ItemBlueBirthLeftScript>();

        //一定時間毎に実行(左より微フレーム遅く)
        InvokeRepeating("SpawnItem", 5.001f, 5.001f);
    }

    void Update()
    {

    }

    void SpawnItem()
    {
        leftSpawnFlag = script.spawnFlagLeft;
        //乱数生成(確率調整)
        int spawnFlagNum = Random.Range(1, 3);  //確率1/3
        //Debug.Log("アイテム(右)発生:" + spawnFlagNum);
        //Debug.Log("アイテム(左)発生:" + leftSpawnFlag);
        if (spawnFlagNum == 1)
        {
            // 生成
            if (leftSpawnFlag == 1)
            {
                // 左が生成されていたら右は生成しない
                return;
            }
            spawnFlagRight = 1;
            // Item_Blueを生成
            Instantiate(Item_Blue, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            //Debug.Log("アイテム(右)発生フラグ:" + spawnFlagRight);
        }
        else
        {
            // 未生成
            spawnFlagRight = 0;
            //Debug.Log("アイテム(右)発生フラグ:" + spawnFlagRight);
        }
    }
}