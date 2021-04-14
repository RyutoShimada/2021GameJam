using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
    [SerializeField] string thisColor;
    int bomsCount = 0;
    GameObject[] boms = new GameObject[5];
    GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.tag != thisColor)
        {
            gameManager.GetComponent<GameManager>().GameOver();
            Destroy(collision.gameObject);//爆発の処理
        }
        else
        {
            boms[bomsCount] = collision.gameObject;
            bomsCount += 1;
            gameManager.GetComponent<GameManager>().CountUp(); ;//カウントアップ関数
            Debug.Log("エリア内のボム" + bomsCount);
            if (bomsCount % 5 == 0)
            {
                bomsCount = 0;
                foreach (var item in boms)
                {
                    Destroy(item);//5個毎に中にいるボムが消える
                }
            }
        }
    }
}
