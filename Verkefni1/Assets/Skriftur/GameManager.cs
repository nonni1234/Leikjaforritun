using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject LevelUI;

    public void CompleteLevel() { // Skrifar 'Borð Klárað' á skjáinn þegar borð er klárað
        LevelUI.SetActive(true);
    }
   public void EndGame () { // Keyrist ef Player rekst á object
       if (gameHasEnded == false) {
       gameHasEnded = true;
       Debug.Log("GAME OVER");
       Invoke("Restart", restartDelay); // Kallar á restart með 1 sek delay
       }
   }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Byrjar næsta scene
    }

} 
