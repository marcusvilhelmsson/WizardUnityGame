using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class projectileShoot : MonoBehaviour
{
    public float speed = 4f;
 
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rbProjectile = GetComponent<Rigidbody2D>();
        rbProjectile.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            Die();
        }
    }
    private void Update()
    {
        Rigidbody2D rbProjectile = GetComponent<Rigidbody2D>();
        if (rbProjectile.position.x > -6.7)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
