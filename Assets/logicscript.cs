using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
   
    
    public AudioSource music;
    public GameObject bgm;
    public int playerScore;
    public int score = 1;
    public Text scoreText;
    public GameObject gameover;

    [ContextMenu("Increase score")]
    public void AddScore(int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        beep();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameover.SetActive(true);
    }
    public void MainMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
     public void beep()
     {
         music.Play();
     }  
     
}
