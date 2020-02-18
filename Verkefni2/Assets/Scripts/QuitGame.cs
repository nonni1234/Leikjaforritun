using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit() { // Hættir í leiknum notað af LeikurBúinn takkanum
        Debug.Log("Quit!");
        Application.Quit();
    }
}
