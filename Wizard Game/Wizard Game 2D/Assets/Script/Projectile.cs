using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public coolDown cooldownScript;
    public double time;
    public double timer;

    // Start is called before the first frame update
    void Start()
    {
       
        time = 0.5;
        timer = time;
    }

    // Update is called once per frame
    public void Update()
    {
        
        timer -= Time.deltaTime;
    }
    public void spawnShoot()
    {
        PlayerAnim playerAnimScript = GameObject.FindGameObjectWithTag("PlayerAnim").GetComponent<PlayerAnim>();
        Transform firePoint = GameObject.FindGameObjectWithTag("FirePoint").transform;

        if (timer < 0)
        {
            Debug.Log("Shot");
            playerAnimScript.PlayerAnimShoot();
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            timer = time;
            Debug.Log("Spawned");
            cooldownScript.cooldown = true;
        }
    }
}
