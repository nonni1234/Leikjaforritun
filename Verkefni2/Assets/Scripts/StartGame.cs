using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
public void GameStart()
    {
        SceneManager.LoadScene(1); // Byrjar leikinn, notað af ByrjaLeik takkanum
    }
}
