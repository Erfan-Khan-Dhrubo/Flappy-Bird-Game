 using TMPro;
 using UnityEngine;

public class logicUpdater : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;

    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
