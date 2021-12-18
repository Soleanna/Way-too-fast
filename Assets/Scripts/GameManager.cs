using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    public bool isGameActive;

    public Button restartButton;

    public void StartGame()
    {
        isGameActive = true;
        GameObject.Find("Start Stuff").gameObject.SetActive(false);
        StartCoroutine(ScoreUp());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ScoreUp()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(1);
            score += 1;
            scoreText.text = "Score: " + score;
        }
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
    }
}