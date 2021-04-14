using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DaitoManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject scoreText;
    TextMeshProUGUI sText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        sText = scoreText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        sText.text = score.ToString("D3");
    }

    public void CountUp()
    {
        score += 1;
        Debug.Log(score);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        Debug.Log("GameOver");
    }
}
