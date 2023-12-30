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
        SceneManager.LoadScene(1);
        }
    }



    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Score: " + currentCoins.ToString() + "/100";
    }
  
}
