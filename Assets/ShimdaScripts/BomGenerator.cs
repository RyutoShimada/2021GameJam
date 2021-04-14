using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] m_boms = null;
    public float m_interval = 3f;
    public int m_count = 1;
    float m_time = 0;
    int m_index = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_time = m_interval;
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        Generate(m_interval, m_count, m_time);
    }


    void Generate(float interval, int count, float time)
    {
        if (time > interval)
        {
            m_time = 0;
            for (int i = 0; i < count; i++)
            {
                m_index = Random.Range(0, m_boms.Length);
                Instantiate(m_boms[m_index], transform.position, transform.rotation);
            }
        }
    }
}
