using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Enemy currentEnemy;
    public Transform canvas;

    //Singleton
    public static EnemyManager instance;

    void Awake ()
    {
        instance = this;
    }

    public void CreateNewEnemy ()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject gameObject = Instantiate(enemyToSpawn, canvas);

        currentEnemy = gameObject.GetComponent<Enemy>();
    }

    public void DefeatEnemy (GameObject enemy)
    {
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.instance.BackgroundCheck();
    }
}
