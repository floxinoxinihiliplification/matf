using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Vector3> spawnPoints;
    public int numberOfEnemies;

    public void Awake()
    {
        spawnedEnemies = new List<GameObject>();
    }

    public GameObject SpawnEnemy()
    {
        int random= Random.Range(0, spawnPoints.Count);
        Vector3 position = spawnPoints[random];
        GameObject makeNewEnemy = Instantiate(enemyPrefab, position, Quaternion.identity);
        Enemy enemy = makeNewEnemy.GetComponent<Enemy>();
        enemy.player = GameObject.Find("Player");
        return makeNewEnemy;
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfEnemies; i++)
        {
            spawnedEnemies.Add(SpawnEnemy());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
