using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Score score;
    public GameObject endscreen;
    public int maxScore = 2; // Hve mikið af coins þú þarft til að vinna
    private void LevelFinished() { // Kallað á þegar öll coins eru tekin
        Debug.Log("Finished");
        endscreen.SetActive(true); // kveikir á endscreen
    }
    public void LoadNextLevel() // Er activated af endscreen og loadar næsta level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ResetLevel() // Resettar level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Reset!");
    }
    public void IncrementScore() // Hækkar score og checkar hvort þú vannst
    {
        score.score++;
        if(score.score >= maxScore)
        {
            LevelFinished();
        }
    }

}
