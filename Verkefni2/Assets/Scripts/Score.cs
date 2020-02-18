using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    private void Update()
    {
        scoreText.text = score.ToString(); // Score á skjánum
    }
}
