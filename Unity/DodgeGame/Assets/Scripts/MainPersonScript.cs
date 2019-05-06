using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPersonScript : MonoBehaviour
{
    //MainPersonの移動速度
    public float mainPersonSpeed = 5f;

    // 初期処理
    void Start()
    {
        
    }

    // フレーム処理
    void Update()
    {
        //z軸に平行移動
        transform.position += new Vector3(0f, 0f, Input.GetAxis("Horizontal")*mainPersonSpeed*Time.deltaTime);
        //Debug.Log(mainPersonSpeed);
    }
}
