using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ScoreUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            score += 1;
        }
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        StartCoroutine("ScoreUp");
    }
}
