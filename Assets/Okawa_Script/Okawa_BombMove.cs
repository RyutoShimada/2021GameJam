using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okawa_BombMove : MonoBehaviour
{
    [SerializeField] float m_pushPowerx;
    [SerializeField] float m_pushPowery;
    Rigidbody2D m_rb2d;
    // Start is called before the first frame update
    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rb2d.velocity = new Vector2(m_pushPowerx, m_pushPowery);
    }
}
