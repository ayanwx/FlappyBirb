using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreViewer;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int num)
    {
        score += num;
        scoreViewer.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
