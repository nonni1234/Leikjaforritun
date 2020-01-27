using UnityEngine;

public class Hætta : MonoBehaviour {
    // Skrifar hætta í consoleið þegar takkinn 'Hætta' er smelltur
    public void Quit()
    {
        Debug.Log("Hætta");
        Application.Quit(); // Þetta myndi hætta í leiknum ef hann væri exported en við þurfum ekki að gera það
    }
}
