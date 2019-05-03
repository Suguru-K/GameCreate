using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //private float speed;
    public float speed; //publicにすることで、inspectorビューで直接設定できる

    // Start is called before the first frame update
    void Start()
    {
        //speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime * speed, 0f, 0f);
        //transform.position：オブジェクトの位置にアクセス
        //Vector3:オブジェクトの位置を指定する
        //Debug.Log(transform.position);
    }
}
