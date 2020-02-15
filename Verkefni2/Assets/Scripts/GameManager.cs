using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Score score;
    public int maxScore = 2;
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Reset!");
    }
    public void IncrementScore()
    {
        score.score++;
        if(score.score >= maxScore)
        {
            LoadNextLevel();
        }
    }

}
