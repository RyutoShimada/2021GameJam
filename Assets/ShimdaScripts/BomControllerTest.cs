using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomControllerTest : MonoBehaviour
{
    Rigidbody2D m_rb;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = gameObject.GetComponent<Rigidbody2D>();
        random = Random.Range(-5, 6);
        m_rb.AddForce(Vector2.left * random, ForceMode2D.Impulse);
    }
}
