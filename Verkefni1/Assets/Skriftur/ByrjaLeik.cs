using UnityEngine;
using UnityEngine.SceneManagement;

public class ByrjaLeik : MonoBehaviour
{
    public void Byrja() // Keyrist þegar það er ýtt á Byrja
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Byrjar leikinn á fyrsta sceneinu
    }
}
