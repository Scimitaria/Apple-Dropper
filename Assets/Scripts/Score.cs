using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public GameObject[] baskets;
    private int i;
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        scoreText.text = "000000";
    }

    void UpdateScore()
    {
        scoreText.text = score.ToString("D6");
    }
    public void OOB()
    {
        if (i > 2)SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        else Destroy(baskets[i]);
        i ++;
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScore();
    }
}

