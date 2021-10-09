using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemySpawner : MonoBehaviour
{

    
    public GameObject enemyPrefab;
    float randomY;
    float randomX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    public float nextSpawn;
    public float numberEnemy = 0;
    public float maxEnemy;
    public double time;
    public double timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        maxEnemy = 0;
        time = 15;
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            maxEnemy++;
            SpawnObject();
            timer = time+10;
        }
    }
    public void SpawnObject()
    { 
        if(numberEnemy < maxEnemy)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randomY = Random.Range(-3, 3);
                randomX = Random.Range(-4, 0);
                whereToSpawn = new Vector2(randomX, randomY);
                Instantiate(enemyPrefab, whereToSpawn, Quaternion.identity);
                numberEnemy++;
            }
        }
    }

}
