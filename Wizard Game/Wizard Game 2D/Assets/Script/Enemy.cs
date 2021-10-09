using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;
    private Rigidbody2D rbEnemy;
    public float nextSpawn;
    float randomY;
    float randomX;
    Vector2 speed;
    public Transform coinPoint;
    public Rigidbody2D rbcoinPrefab;
    public float currentpositiony;
    public gameController gameControllerscript;
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (this.rbEnemy.position.x > -7)
        {
            this.rbEnemy.velocity = new Vector2(-1f, 0);
        }
        else
        {
            this.rbEnemy.velocity = Vector2.zero;
            
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.gameObject.CompareTag("fireballTag"))
        {
            SpawnCoin();
            gameControllerscript.AddCoin();
            Die();
        }
    }
    private void Die()
    {
        randomY = Random.Range(-3, 3);
        randomX = Random.Range(-4, 0);
        rbEnemy.position = new Vector2(randomX, randomY);
    }
    public void SpawnCoin()
    {
        Rigidbody2D spawnedCoin = Instantiate(rbcoinPrefab, coinPoint.position, coinPoint.rotation);
        currentpositiony = coinPoint.position.y;
        spawnedCoin.velocity = new Vector2(0, 2);
        StartCoroutine(MyMethod(spawnedCoin));
    }
    IEnumerator MyMethod(Rigidbody2D spawnedCoin)
    {
        yield return new WaitForSeconds(1);
        Destroy(spawnedCoin.gameObject);
    }
}
