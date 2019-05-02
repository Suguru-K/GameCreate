using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private float speed; //ボール毎に速度が変わるよう、変数で保持

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 15f);
        //速度はランダム(5〜15)
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        //手前に移動させる

        if(transform.position.z < -13.0f)
        {
            //Debug.Log("Game Over");
            //Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    //※unity上でPaddleオブジェクトにPaddleタグをつけておく
    //衝突時のメソッド(衝突するオブジェクト)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        //衝突した時の処理
        {
            Destroy(gameObject);
            //オブジェクトを消す
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            if(collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
    }
}
