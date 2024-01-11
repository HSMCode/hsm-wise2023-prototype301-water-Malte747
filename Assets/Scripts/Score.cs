using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score instance;

    public TMP_Text coinText;
    public int currentCoins;


    public GameObject gameOverScreen;
    public GameObject buttonRestart;
    public GameObject winScreen;


    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinText.text = "Score: " + currentCoins.ToString() + "/100";
    }

    void Update()
    {
         if(currentCoins >= 100)
         {
            won();
            FindObjectOfType<Movement>().ui = true;
         }
    }



    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Score: " + currentCoins.ToString() + "/100";
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void won()
    {
        winScreen.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
  
}
