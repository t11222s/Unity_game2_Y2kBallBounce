using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text score;
    public GameObject gameOver;

    //public GameObject gameOverScreen;
    [ContextMenu("Increment score")]
    public void addScore(int scoretoadd)
    {
        playerScore+= scoretoadd;
        score.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOverS()
    {
        gameOver.SetActive(true);
    }

}
