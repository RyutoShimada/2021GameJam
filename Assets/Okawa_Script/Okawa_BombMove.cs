using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okawa_BombMove : MonoBehaviour
{
    [SerializeField] float m_pushPowerxMax;
    [SerializeField] float m_pushPowerxMin;
    [SerializeField] float m_pushPoweryMax;
    [SerializeField] float m_pushPoweryMin;
    [SerializeField] float m_lifetime;
    [SerializeField] float m_destroyTime;
    float m_pushPowerX;
    float m_pushPowerY;
    float time;
    Rigidbody2D m_rb2d;
    // Start is called before the first frame update
    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        m_pushPowerX = Random.Range(m_pushPowerxMin, m_pushPowerxMax);
        m_pushPowerY = Random.Range(m_pushPoweryMin, m_pushPoweryMax);
        m_rb2d.AddForce(new Vector2(m_pushPowerX,m_pushPowerY), ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= m_lifetime)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject,m_destroyTime);
    }

    
}
