 using TMPro;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 public class logicUpdater : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;

    public GameObject gameOverText;
    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // ?
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
    }

}
