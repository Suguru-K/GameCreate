using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRedScript : MonoBehaviour
{
    public float Item_red_speed = 5f;  // 赤玉の速度

    void Start()
    {

    }

    void Update()
    {
        // x+方向のみに動く
        transform.position += new Vector3(Item_red_speed * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //MainPersonかCube_Backに重なった場合
        if (other.gameObject.CompareTag("MainPerson") || other.gameObject.CompareTag("Cube_Back"))
        {
            //Itemを消す
            Destroy(gameObject);
        }
    }
}
