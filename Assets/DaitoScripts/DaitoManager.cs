using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaitoManager : MonoBehaviour
{
    int score = 0;
    bool m_isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountUp()
    {
        score += 1;
        Debug.Log(score);
    }

    public void GameOver()
    {
        m_isGameOver = true;
        Debug.Log("GameOver");
    }
}
