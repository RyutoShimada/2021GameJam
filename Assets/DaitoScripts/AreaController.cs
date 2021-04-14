using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
    [SerializeField] string thisColor;
    public int bomsCount;
    GameObject[] boms = new GameObject[5];
    int i = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.tag != thisColor)
        {
            Destroy(collision.gameObject);//爆発の処理
        }
        else
        {
            boms[i] = collision.gameObject;
            i += 1;
            bomsCount += 1;//カウントアップ関数
            Debug.Log(bomsCount);
            if (bomsCount % 5 == 0)
            {
                foreach (var item in boms)
                {
                    Destroy(item);//5個毎に中にいるボムが消える
                }
            }
        }
    }
}
