using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlueBirthLeftScript : MonoBehaviour
{
    public GameObject Item_Blue;  //ItemBlue(Prehab)オブジェクト
    GameObject itemBlueBirthRight;  //ItemBlueBirthRight(Empty)オブジェクト
    ItemBlueBirthRightScript script; //ItemBlueBirthRightスクリプト
    public int spawnFlagLeft = 0;  //アイテム発生(左)フラグ

    void Start()
    {
        //ItemBlueBirthRight(Empty)オブジェクトをfind
        itemBlueBirthRight = GameObject.Find("ItemBlueBirthRight");

        //ItemBlueBirthRightScriptを取得
        script = itemBlueBirthRight.GetComponent<ItemBlueBirthRightScript>();

        //一定時間毎に実行
        InvokeRepeating("SpawnItem", 5f, 5f);
    }

    void Update()
    {

    }

    void SpawnItem()
    {
        //乱数生成(確率調整)
        int spawnFlagNum = Random.Range(1, 3);  //確率1/3
        //Debug.Log("青玉乱数:" + spawnFlagNum);
        if (spawnFlagNum == 1)
        {
            // 生成
            spawnFlagLeft = 1;
            // Item_Blueを生成
            Instantiate(Item_Blue, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            //Debug.Log("アイテム(左)発生フラグ:" + spawnFlagLeft);
        }
        else
        {
            // 未生成
            spawnFlagLeft = 0;
            //Debug.Log("アイテム(左)発生フラグ:" + spawnFlagLeft);
        }
    }
}