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
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
  
}
