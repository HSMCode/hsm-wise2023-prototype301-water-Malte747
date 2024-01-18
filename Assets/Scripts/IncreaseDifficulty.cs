using UnityEngine;

public class IncreaseDifficulty : MonoBehaviour
{

    private float calculateDifficulty = 0f;
    public GameObject enemyPrefab;
    //

    void Start()
    {
        enemyPrefab.GetComponent<EnemyBehaviour>().speed = -5f;
    }
    
    void Update()
    {
    
        if (calculateDifficulty + 10f < this.GetComponent<Score>().currentCoins)
        {
            EnemyBehaviour[] enemies = Resources.FindObjectsOfTypeAll<EnemyBehaviour>();
            for (int i = 1; i < enemies.Length; i++)
            {
                enemies[i].speed -= 2f;
            }

            calculateDifficulty +=  10f;
        }
    }

}
