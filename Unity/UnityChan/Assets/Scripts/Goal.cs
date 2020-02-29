using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //ゴールした場合
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("GOAL!");
        }
    }
}
