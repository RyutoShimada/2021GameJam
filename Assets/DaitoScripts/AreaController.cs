using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
    [SerializeField] string thisColor;
    public int boms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.tag != thisColor)
        {
            Destroy(collision.gameObject);//爆発の処理
        }
        else
        {
            boms += 1;
            Debug.Log(boms);
        }
    }
}
