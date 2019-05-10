using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPersonScript : MonoBehaviour
{
    public float mainPersonSpeed = 5f;  //MainPersonの移動速度
    public static int itemRedGetNum = 0;  //赤玉取得数
    private Vector3 player_pos;  //オブジェクトの位置

    void Start()
    {

    }

    void Update()
    {
        //移動範囲を制限
        player_pos = transform.position; //プレイヤーの位置を取得
        player_pos.z = Mathf.Clamp(player_pos.z, -4f, 4f); //x位置が常に範囲内か監視
        transform.position = new Vector3(player_pos.x, player_pos.y, player_pos.z); //範囲内であれば常にその位置がそのまま入る

        //移動スピードを計算
        transform.position += new Vector3(0f, 0f, Input.GetAxis("Horizontal") * mainPersonSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //ItemBlueに重なった場合
        if (other.gameObject.CompareTag("itemBlue"))
        {
            mainPersonSpeed += 2f;
            //Debug.Log(mainPersonSpeed);
        }
        //ItemRedに重なった場合
        if (other.gameObject.CompareTag("itemRed"))
        {
            itemRedGetNum += 10;
            Debug.Log("スコア"+itemRedGetNum);
        }
    }

    // getter
    public static int GetItemRedGetNum()
    {
        return itemRedGetNum;
    }
}