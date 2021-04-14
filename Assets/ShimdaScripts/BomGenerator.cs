using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] m_boms = null;
    [SerializeField] float m_interval = 1f;
    float m_time = 0;
    int m_index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;

        if (m_time > m_interval)
        {
            m_time = 0;
            m_index = Random.Range(0, m_boms.Length);
            Instantiate(m_boms[m_index], transform.position, transform.rotation);
        }
    }
}
