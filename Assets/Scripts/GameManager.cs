using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject scoreText;
    TextMeshProUGUI sText;

    [SerializeField] GameObject m_generator = null;
    [SerializeField] GameObject m_2ndGenerator = null;
    BomGenerator m_bomGenerator;
    BomGenerator m_bomGenerator2nd;
    float m_time = 0;
    float m_levelUpInterval = 10;
    int m_level = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        sText = scoreText.GetComponent<TextMeshProUGUI>();

        m_bomGenerator = m_generator.GetComponent<BomGenerator>();
        m_bomGenerator2nd = m_2ndGenerator.GetComponent<BomGenerator>();
        m_2ndGenerator.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sText.text = score.ToString("D3");

        m_time += Time.deltaTime;
        Debug.Log((int)m_time);
        LevelControl();
        Switch();
    }

    void LevelControl()
    {
        if (m_time > m_levelUpInterval)
        {
            m_time = 0;
            if (m_level <= 6)
            {
                m_level++;
            }
        }
    }

    void Switch()
    {
        switch (m_level)
        {
            case 1:
                Level1();
                break;
            case 2:
                Level2();
                break;
            case 3:
                Level3();
                break;
            case 4:
                Level4();
                break;
            case 5:
                Level5();
                break;
            case 6:
                Level6();
                break;
            default:
                break;
        }
    }

    void Stop()
    {
        Destroy(m_bomGenerator.gameObject);
        Destroy(m_2ndGenerator.gameObject);
    }

    /// <summary>
    /// 3秒おきに1個ずつ生成
    /// </summary>
    void Level1()
    {
        m_bomGenerator.m_interval = 3f;
        m_bomGenerator.m_count = 1;
    }

    /// <summary>
    /// 上下から1個ずつ生成。上からは2秒おき、下からは2，5秒おき
    /// </summary>
    void Level2()
    {
        m_2ndGenerator.gameObject.SetActive(true);

        m_bomGenerator.m_interval = 2f;
        m_bomGenerator.m_count = 1;

        m_bomGenerator2nd.m_interval = 2.5f;
        m_bomGenerator2nd.m_count = 1;
    }

    /// <summary>
    /// 上から2個だし
    /// </summary>
    void Level3()
    {
        m_bomGenerator.m_interval = 2f;
        m_bomGenerator.m_count = 2;

        m_bomGenerator2nd.m_interval = 2.5f;
        m_bomGenerator2nd.m_count = 1;
    }

    /// <summary>
    /// 上下からも2個だし。上からは1.5秒おき、下からは2秒おき
    /// </summary>
    void Level4()
    {
        m_bomGenerator.m_interval = 1.5f;
        m_bomGenerator.m_count = 2;

        m_bomGenerator2nd.m_interval = 2f;
        m_bomGenerator2nd.m_count = 2;
    }

    /// <summary>
    /// 上から3個だし
    /// </summary>
    void Level5()
    {
        m_bomGenerator.m_interval = 1.5f;
        m_bomGenerator.m_count = 3;

        m_bomGenerator2nd.m_interval = 2f;
        m_bomGenerator2nd.m_count = 2;
    }

    /// <summary>
    /// 上下から3個だし。上からは1秒おき、下からは1.5秒おき
    /// </summary>
    void Level6()
    {
        m_bomGenerator.m_interval = 1f;
        m_bomGenerator.m_count = 3;

        m_bomGenerator2nd.m_interval = 1.5f;
        m_bomGenerator2nd.m_count = 3;
    }

    public void CountUp()
    {
        score += 1;
        Debug.Log(score);
    }

    public void GameOver()
    {
        Stop();
        gameOverText.SetActive(true);
        Debug.Log("GameOver");
    }

}
